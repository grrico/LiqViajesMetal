using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace LiqMetalDMS_Bll_Data
{
	/// <summary>
	/// Class that provides extended methods for sorting and filtering paged and normal lists
	/// </summary>
	/// <typeparam name="T">Object of T</typeparam>
	public class SerializableList<T> : BindingList<T> //, IXmlSerializable
		where T : IXmlSerializable, new()
	{
		#region IXmlSerializable Members

		/// <summary>
		/// Returs the object's schema
		/// </summary>
		/// <returns></returns>
		public System.Xml.Schema.XmlSchema GetSchema()
		{
			XmlSchema schema = new System.Xml.Schema.XmlSchema();

			schema.Namespaces.Add("xsd", "http://www.w3.org/2001/XMLSchema");
			schema.Namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
			schema.Namespaces.Add("", GetType().Namespace);
			schema.Id = GetType().Name + "Schema";
			schema.TargetNamespace = GetType().Namespace;

			XmlSchemaSequence sequence = new XmlSchemaSequence();

			XmlSchemaElement el = new XmlSchemaElement();
			el.Name = GetType().Name;
			el.SchemaType = new XmlSchemaComplexType();

			//--------------------------
			// add child elements
			T tm = new T();
			XmlSchema schemaT = tm.GetSchema();

			foreach (XmlSchemaObject xso in schemaT.Items)
				sequence.Items.Add(xso);
			//--------------------------

			((XmlSchemaComplexType) el.SchemaType).Particle = sequence;
			schema.Items.Add(el);

			return schema;
		}

		/// <summary>
		/// Reads data from an Xml stream
		/// </summary>
		/// <param name="reader"></param>
		public void ReadXml(XmlReader reader)
		{
            try
            {
                reader.MoveToContent();

                // Read objects
                int depth = reader.Depth;
                bool read = reader.Read();
                while ((read) && (reader.Depth > depth))
                {
                    reader.MoveToContent();

                    //Pattern for complex/composed objects
                    if ((reader.Name == typeof(T).Name) && (reader.IsStartElement()))
                    {
                        T tm = new T();
                        tm.ReadXml(reader);
                        Add(tm);
                    }

                    read = reader.Read();
                }
            }
            catch (Exception e)
            {
                string x="error" + e.Message ;
            }
		}

		/// <summary>
		/// Writes data from an Xml stream
		/// </summary>
		/// <param name="writer"></param>
		public void WriteXml(XmlWriter writer)
		{
			//Pattern for complex/composed objects
			foreach (T tm in this)
			{
				writer.WriteStartElement(typeof(T).Name);
				tm.WriteXml(writer);
				writer.WriteEndElement();
			}
		}
        
		#endregion

		/// <summary>
		/// Delegates predicate for perform searching
		/// </summary>
		/// <param name="obj">Reference to an instance of T</param>
		/// <returns>Must return true for the searching criteria</returns>
		public delegate bool Predicate(T obj);

		/// <summary>
		/// Returns the reference to an object that exists inside this collection and match the searching criteria
		/// </summary>
		/// <param name="match">Delegate for looking the matching criteria</param>
		/// <returns>Object's reference or null if not found</returns>
		public T Find(Predicate<T> match)
		{
			foreach (T t in this)
			{
				if (match(t))
					return t;
			}

			return default(T);
		}

		/// <summary>
		/// Returns true if the an object exist inside this collection
		/// </summary>
		/// <param name="match">Delegate for looking the matching criteria</param>
		/// <returns>True if object exists inside this collection</returns>
		public bool Exists(Predicate<T> match)
		{
			foreach (T t in this)
			{
				if (match(t))
					return true;
			}

			return false;
		}


		/// <summary>
		/// Default constructor
		/// </summary>
		public SerializableList()
		{
			PageNum = 0;
			PageSize = 0;
			
			Filter = "";
			Sort = "";
			
			ExTablesFilter = "";
			ExTablesFieldsFilter = "";
			ExTablesRelationsFilter = "";
			
			ExTablesSort = "";
			ExTablesFieldsSort = "";
			ExTablesRelationsSort = "";

			FilterExtended = "";
			FilterExtendedTables = "";
			FilterExtendedTablesFields = "";
			FilterExtendedTablesRelations = "";
		}

		#region Sorting support

		// Sorting direction
		protected ListSortDirection _sortDirection;

		// Current sorting property descriptor
		protected PropertyDescriptor _sortProperty;

		// True if the list is sorted
		protected bool _isSorted;

		/// <summary>
		/// Always returns true for sorting supports
		/// </summary>
		protected override bool SupportsSortingCore
		{
			get { return true; }
		}

		/// <summary>
		/// Returns the current sorting status
		/// </summary>
		protected override bool IsSortedCore
		{
			get { return _isSorted; }
		}

		/// <summary>
		/// Returns the current sorting direction
		/// </summary>
		protected override ListSortDirection SortDirectionCore
		{
			get { return _sortDirection; }
		}

		/// <summary>
		/// Returns the current sorting property
		/// </summary>
		protected override PropertyDescriptor SortPropertyCore
		{
			get { return _sortProperty; }
		}

		/// <summary>
		/// Applies the sorting routing the this list
		/// </summary>
		/// <param name="property">Sorting property</param>
		/// <param name="direction">Sorting direction</param>
		protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
		{
			if (PageSize <= 0)
			{
				// Try internal sort for special properties
				if (InternalSort(property.Name, direction))
				{
					_sortDirection = direction;
					_sortProperty = property;
					_isSorted = true;

					return;
				}

				// Get list to sort
				List<T> items = this.Items as List<T>;

				// Apply and set the sort, if items to sort
				if (items != null)
				{
					PropertyComparer<T> pc = new PropertyComparer<T>(property, direction);
					items.Sort(pc);

					_sortDirection = direction;
					_sortProperty = property;
					_isSorted = true;

					// Let bound controls know they should refresh their views
					this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
				}
				else
				{
					_isSorted = false;
				}
			}
			else
			{
				// Paging and sorting
				SetSort(property.Name, direction);

				if (_isSorted)
				{
					_sortDirection = direction;
					_sortProperty = property;
				}
			}
		}

		/// <summary>
		/// Provides an internal sorting routine for managing special properties, such as, referenced objects
		/// </summary>
		/// <remarks>Must be overrided if we need to sort the list for referenced object's properties</remarks>
		/// <param name="property">Sorting property</param>
		/// <param name="direction">Sorting direction</param>
		/// <returns>True if the list was sorted to avoid normal sorting routine</returns>
		protected virtual bool InternalSort(string propertyname, ListSortDirection direction)
		{
			return false;
		}

		/// <summary>
		/// Provides the sorting routine for managing paged list.  Callers must call this routing programmatically for sorting paged list.
		/// </summary>
		/// <remarks>Must be overrided to perform the sorting routine for paged list.</remarks>
		/// <param name="property">Sorting property</param>
		/// <param name="direction">Sorting direction</param>
		public virtual void SetSort(string propertyname, ListSortDirection direction)
		{
			_isSorted = false;
		}

		/// <summary>
		/// Returns the property's value for an object at the <paramref name="index"/> position in one paged list.
		/// </summary>
		/// <remarks>If this object isn't in memory, the paged list must read it and returns the expected property's value</remarks>
		/// <param name="index">Object's position in the paged list</param>
		/// <param name="propertyname">Property's name.  It can be a composed property name for referenced object's properties such as "Person.City.Name"</param>
		/// <returns>The property's value or "" if an error was raised</returns>
		public virtual object GetValue(int index, string propertyname)
		{
			return "";
		}

		/// <summary>
		/// Provides the extended filtering routine for managing paged list.  Callers must call this routing programmatically for filtering paged list.
		/// </summary>
		/// <remarks>Must be overrided to perform the filtering routine for paged list.</remarks>
		/// <param name="propertyname">Property's name.  It can be a composed property name for referenced object's properties such as "Person.City.Name"</param>
		/// <param name="value">Property's value</param>
		/// <param name="oper">Operator such as =, >=, Like, etc.</param>
		/// <param name="separator">Separator like an apostrophe (')</param>
		public virtual void SetExtendedFilter(string propertyname, string value, string oper, string separator)
		{
		}

		/// <summary>
		/// Removes the current sorting
		/// </summary>
		protected override void RemoveSortCore()
		{
			_isSorted = false;
			_sortProperty = null;

			// remove sorting
			SetSort("", ListSortDirection.Ascending);
		}

		#endregion 

		#region Filter, Paging, sorting fields/attributes

		private int _pagenum;
		private int _pagesize;
		private int _totalcount;
		private string _filter;	// pre-filtered list
		private string _filter_extables;
		private string _filter_extablesfields;
		private string _filter_extablesrelations;
		private string _ex_filter;	// extended filter
		private string _ex_filter_tables;
		private string _ex_filter_tablesfields;
		private string _ex_filter_tablesrelations;
		private string _sort;  // extended sort
		private string _sort_table;
		private string _sort_tablefields;
		private string _sort_tablerelations;

		/// <summary>
		/// Gets the current page number
		/// </summary>
		public int PageNum
		{
			get { return _pagenum; }
			set 
			{ 
				_pagenum = value;
				if (_pagenum <= 0)
					_pagenum = 0;
			}
		}

		/// <summary>
		/// Gets the page size
		/// </summary>
		public int PageSize
		{
			get { return _pagesize; }
			set { _pagesize = value; }
		}

		/// <summary>
		/// Gets the current filter statement
		/// </summary>
		public string Filter
		{
			get 
			{ 
				string filter = _filter;

				if (_ex_filter != "")
				{
					if (filter != "")
						filter += " AND " + _ex_filter;
					else
						filter = _ex_filter;
				}
				
				return filter; 
			}
			set { _filter = value; }
		}

		/// <summary>
		/// Returns the current sorting statement
		/// </summary>
		public string Sort
		{
			get { return _sort; }
			set { _sort = value; }
		}

		/// <summary>
		/// Gets the extra tables for apply the filter
		/// </summary>
		public string ExTablesFilter
		{
			get 
			{ 
				string filter_extables = _filter_extables;

				if (_ex_filter_tables != "")
				{
					if (filter_extables != "")
						filter_extables += "," + _ex_filter_tables;
					else
						filter_extables = _ex_filter_tables;
				}
				
				return filter_extables; 
			}
			set { _filter_extables = value; }
		}

		/// <summary>
		/// Gets the extra tables's fields for apply the filter
		/// </summary>
		public string ExTablesFieldsFilter
		{
			get 
			{ 
				string filter_extablesfields = _filter_extablesfields;

				if (_ex_filter_tablesfields != "")
				{
					if (filter_extablesfields != "")
						filter_extablesfields += "," + _ex_filter_tablesfields;
					else
						filter_extablesfields = _ex_filter_tablesfields;
				}
				
				return filter_extablesfields; 
			}

			set { _filter_extablesfields = value; }
		}

		/// <summary>
		/// Gets the extra tables's relations for apply the filter
		/// </summary>
		public string ExTablesRelationsFilter
		{
			get 
			{ 
				string filter_extablesrelations =  _filter_extablesrelations;

				if (_ex_filter_tablesrelations != "")
				{
					if (filter_extablesrelations != "")
						filter_extablesrelations += " AND " + _ex_filter_tablesrelations;
					else
						filter_extablesrelations = _ex_filter_tablesrelations;
				}
				
				return filter_extablesrelations; 
			}
			set { _filter_extablesrelations = value; }
		}

		/// <summary>
		/// Gets the extra tables for apply the sorting routine for composed objects
		/// </summary>
		public string ExTablesSort
		{
			get { return _sort_table; }
			set { _sort_table = value; }
		}

		/// <summary>
		/// Gets the extra tables's fields for apply the sorting routine for composed objects
		/// </summary>
		public string ExTablesFieldsSort
		{
			get { return _sort_tablefields; }
			set { _sort_tablefields = value; }
		}

		/// <summary>
		/// Gets the extra tables's relations for apply the sorting routine for composed objects
		/// </summary>
		public string ExTablesRelationsSort
		{
			get { return _sort_tablerelations; }
			set { _sort_tablerelations = value; }
		}

		/// <summary>
		/// Returns the extended filter statement
		/// </summary>
		public string FilterExtended
		{
			get { return _ex_filter; }
			set { _ex_filter = value; }
		}

		/// <summary>
		/// Gets the extra tables for apply the extended filtering
		/// </summary>
		public string FilterExtendedTables
		{
			get { return _ex_filter_tables; }
			set { _ex_filter_tables = value; }
		}

		/// <summary>
		/// Gets the extra tables's fields for apply the extended filtering
		/// </summary>
		public string FilterExtendedTablesFields
		{
			get { return _ex_filter_tablesfields; }
			set { _ex_filter_tablesfields = value; }
		}

		/// <summary>
		/// Gets the extra tables's relations for apply the extended filtering
		/// </summary>
		public string FilterExtendedTablesRelations
		{
			get { return _ex_filter_tablesrelations; }
			set { _ex_filter_tablesrelations = value; }
		}

		/// <summary>
		/// Returns true if the list has an extended filtering applied
		/// </summary>
		public bool IsFilterExtended
		{
			get { return _ex_filter != ""; }
		}

		/// <summary>
		/// Returns the total count of objects that can be obtained from the paged list. 
		/// <para>This property is different to <i>Count</i> property because <i>Count</i> only returns the number of objects in memory.</para>
		/// </summary>
		public int TotalCount
		{
			get 
			{
				if (PageSize == 0)
					return this.Count;
				else
					return _totalcount; 
			}
			set { _totalcount = value; }
		}

		#endregion
	}
}
