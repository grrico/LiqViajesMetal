using System;
using System.Data;
using System.Data.Common;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sinapsys.Datos;
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{
	#region UsuariosController

	/// <summary>
	/// Class for convert data from database into object's data and vice versa
	/// </summary>
	public partial class UsuariosController//: ILatinodeController
	{
		/// <summary>
		/// Generic Constructor
		/// </summary>
		public UsuariosController()
		{
		}

		/// <summary>
		/// Instance accessor for this singleton
		/// </summary>
		private static UsuariosController MySingleObj;
		public static UsuariosController Instance
		{
			get
			{
				if (MySingleObj == null)
				{
					MySingleObj = new UsuariosController();
				}
				return MySingleObj;
			}
		}

		// Reads object's data from a DataRow
		private void ReadData(Usuarios usuarios, DataRow dr,bool generateUndo=false)
		{
			try 
			{
				usuarios.lngIdUsuario = (int) dr["lngIdUsuario"];
				usuarios.strLogin = dr.IsNull("strLogin") ? null :(string) dr["strLogin"];
				usuarios.strNombre = dr.IsNull("strNombre") ? null :(string) dr["strNombre"];
				usuarios.strPassword = dr.IsNull("strPassword") ? null :(string) dr["strPassword"];
				usuarios.dtmFechaSistema = dr.IsNull("dtmFechaSistema") ? null :(DateTime?) dr["dtmFechaSistema"];
				usuarios.Excell = dr.IsNull("Excell") ? null :(bool?) dr["Excell"];
				usuarios.Modifica_gastos = dr.IsNull("Modifica_gastos") ? null :(bool?) dr["Modifica_gastos"];
				usuarios.Modifica_cd = dr.IsNull("Modifica_cd") ? null :(bool?) dr["Modifica_cd"];
			}
			catch (Exception ex)
			{
				Utilidades.LogErrores(ex.Message + (ex.InnerException != null ? ex.InnerException.Message : ""), DataProvider.AplicacionNombre);
				throw ex;
			}
			if (generateUndo) usuarios.GenerateUndo();
		}

		/// <summary>
		/// Create a new Usuarios object by passing a object
		/// </summary>
		public Usuarios Create(Usuarios usuarios, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			return Create(usuarios.lngIdUsuario,usuarios.strLogin,usuarios.strNombre,usuarios.strPassword,usuarios.dtmFechaSistema,usuarios.Excell,usuarios.Modifica_gastos,usuarios.Modifica_cd,datosTransaccion);
		}

		/// <summary>
		/// Creates a new Usuarios object by passing all object's fields
		/// </summary>
		/// <param name="strLogin">string that contents the strLogin value for the Usuarios object</param>
		/// <param name="strNombre">string that contents the strNombre value for the Usuarios object</param>
		/// <param name="strPassword">string that contents the strPassword value for the Usuarios object</param>
		/// <param name="dtmFechaSistema">DateTime that contents the dtmFechaSistema value for the Usuarios object</param>
		/// <param name="Excell">bool that contents the Excell value for the Usuarios object</param>
		/// <param name="Modifica_gastos">bool that contents the Modifica_gastos value for the Usuarios object</param>
		/// <param name="Modifica_cd">bool that contents the Modifica_cd value for the Usuarios object</param>
		/// <returns>One Usuarios object</returns>
		public Usuarios Create(int lngIdUsuario, string strLogin, string strNombre, string strPassword, DateTime? dtmFechaSistema, bool? Excell, bool? Modifica_gastos, bool? Modifica_cd, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Usuarios usuarios = new Usuarios();

				usuarios.lngIdUsuario = lngIdUsuario;
				usuarios.lngIdUsuario = lngIdUsuario;
				usuarios.strLogin = strLogin;
				usuarios.strNombre = strNombre;
				usuarios.strPassword = strPassword;
				usuarios.dtmFechaSistema = dtmFechaSistema;
				usuarios.Excell = Excell;
				usuarios.Modifica_gastos = Modifica_gastos;
				usuarios.Modifica_cd = Modifica_cd;
				lngIdUsuario = UsuariosDataProvider.Instance.Create(lngIdUsuario, strLogin, strNombre, strPassword, dtmFechaSistema, Excell, Modifica_gastos, Modifica_cd,"Usuarios",datosTransaccion);
				if (lngIdUsuario == 0)
					return null;

				usuarios.lngIdUsuario = lngIdUsuario;

				return usuarios;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Usuarios object by passing all object's fields
		/// </summary>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the Usuarios object</param>
		/// <param name="strLogin">string that contents the strLogin value for the Usuarios object</param>
		/// <param name="strNombre">string that contents the strNombre value for the Usuarios object</param>
		/// <param name="strPassword">string that contents the strPassword value for the Usuarios object</param>
		/// <param name="dtmFechaSistema">DateTime that contents the dtmFechaSistema value for the Usuarios object</param>
		/// <param name="Excell">bool that contents the Excell value for the Usuarios object</param>
		/// <param name="Modifica_gastos">bool that contents the Modifica_gastos value for the Usuarios object</param>
		/// <param name="Modifica_cd">bool that contents the Modifica_cd value for the Usuarios object</param>
		public void Update(int lngIdUsuario, string strLogin, string strNombre, string strPassword, DateTime? dtmFechaSistema, bool? Excell, bool? Modifica_gastos, bool? Modifica_cd, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				Usuarios new_values = new Usuarios();
				new_values.strLogin = strLogin;
				new_values.strNombre = strNombre;
				new_values.strPassword = strPassword;
				new_values.dtmFechaSistema = dtmFechaSistema;
				new_values.Excell = Excell;
				new_values.Modifica_gastos = Modifica_gastos;
				new_values.Modifica_cd = Modifica_cd;
				UsuariosDataProvider.Instance.Update(lngIdUsuario, strLogin, strNombre, strPassword, dtmFechaSistema, Excell, Modifica_gastos, Modifica_cd,"Usuarios",datosTransaccion);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Updates an Usuarios object by passing one object's instance as reference
		/// </summary>
		/// <param name="usuarios">An instance of Usuarios for reference</param>
		public void Update(Usuarios usuarios,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Update(usuarios.lngIdUsuario, usuarios.strLogin, usuarios.strNombre, usuarios.strPassword, usuarios.dtmFechaSistema, usuarios.Excell, usuarios.Modifica_gastos, usuarios.Modifica_cd);
		}

		/// <summary>
		/// Delete  the Usuarios object by passing a object
		/// </summary>
		public void  Delete(Usuarios usuarios, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			Delete(usuarios.lngIdUsuario,datosTransaccion);
		}

		/// <summary>
		/// Deletes the Usuarios object by passing one object's instance as reference
		/// </summary>
		/// <param name="usuarios">An instance of Usuarios for reference</param>
		public void Delete(int lngIdUsuario, Sinapsys.Datos.SQL datosTransaccion=null)
		{
			try 
			{
				//Usuarios old_values = UsuariosController.Instance.Get(lngIdUsuario);
				//if(!Validate.security.CanDeleteSecurityField(UsuariosController.Instance, (ILatinodeObject)old_values))
				//    throw new Exception("Access denied by security field, you can't delete object");

				UsuariosDataProvider.Instance.Delete(lngIdUsuario,"Usuarios");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Deletes the Usuarios object by passing CVS parameter as reference
		/// </summary>
		/// <param name="usuarios">An instance of Usuarios for reference</param>
		public void Delete(string CVSParameter)
		{
			string[] StrCommand=CVSParameter.Split(',');
			try 
			{
				int lngIdUsuario=int.Parse(StrCommand[0]);
				UsuariosDataProvider.Instance.Delete(lngIdUsuario,"Usuarios");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets the Usuarios object by passing the object's key fields
		/// </summary>
		/// <param name="lngIdUsuario">int that contents the lngIdUsuario value for the Usuarios object</param>
		/// <returns>One Usuarios object</returns>
		public Usuarios Get(int lngIdUsuario, bool generateUndo=false)
		{
			try 
			{
				Usuarios usuarios = null;
				DataTable dt = UsuariosDataProvider.Instance.Get(lngIdUsuario);
				if ((dt.Rows.Count > 0))
				{
					usuarios = new Usuarios();
					DataRow dr = dt.Rows[0];
					ReadData(usuarios, dr, generateUndo);
				}


				return usuarios;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Usuarios
		/// </summary>
		/// <returns>One UsuariosList object</returns>
		public UsuariosList GetAll(bool generateUndo=false)
		{
			try 
			{
				UsuariosList usuarioslist = new UsuariosList();
				DataTable dt = UsuariosDataProvider.Instance.GetAll();
				foreach (DataRow dr in dt.Rows)
				{
					Usuarios usuarios = new Usuarios();
					ReadData(usuarios, dr, generateUndo);
					usuarioslist.Add(usuarios);
				}
				return usuarioslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Gets all objects of Usuarios applying filter and sort criteria
		/// </summary>
		/// <param name="pagenum">Contents the page number (z-ordered) of records to return.</param>
		/// <param name="pagesize">Contents the number of records per page (0 for returns all records).</param>
		/// <param name="filter">Contents the criteria (as SQL sentence) for filter records (ex. Qty > 0).</param>
		/// <param name="sort">Contents the criteria (as SQL sentence) for filter records (ex. Name ASC).</param>
		/// <param name="extablesfilter">Contents extra tables for make relations in filter operations (ex. extratable).</param>
		/// <param name="extablesfieldsfilter">Contents extra tables's fields for make relations in filter operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationsfilter">Contents the relations with extra tables in filter operations (ex. table.id=extratable.id).</param>
		/// <param name="extablessort">Contents extra tables for make relations in sort operations (ex. extratable).</param>
		/// <param name="extablesfieldssort">Contents extra tables's fields for make relations in sort operations  (ex. extratable.field)</param>
		/// <param name="extablesrelationssort">Contents the relations with extra tables in sort operations (ex. table.id=extratable.id).</param>
		/// <returns>One UsuariosList object</returns>
		public UsuariosList GetFilter(int pagenum, int pagesize, string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			try 
			{
				UsuariosList usuarioslist = new UsuariosList();

				DataTable dt = UsuariosDataProvider.Instance.GetFilter(pagenum, pagesize, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort);

				foreach (DataRow dr in dt.Rows)
				{
					Usuarios usuarios = new Usuarios();
					ReadData(usuarios, dr, generateUndo);
					usuarioslist.Add(usuarios);
				}
				return usuarioslist;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public UsuariosList GetFilter( string filter, string sort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, "","","","","","",generateUndo);
		}

		public UsuariosList GetFilter(string filter, string sort, string extablesfilter, string extablesfieldsfilter, string extablesrelationsfilter, string extablessort, string extablesfieldssort, string extablesrelationssort, bool generateUndo=false)
		{
			return GetFilter(0,0, filter, sort, extablesfilter, extablesfieldsfilter, extablesrelationsfilter, extablessort, extablesfieldssort, extablesrelationssort,generateUndo);
		}


		/// <summary>
		/// Returns the type for one property
		/// </summary>
		/// <param name="propertyname">Property's name for return its value</param>
		/// <returns>A value for the <paramref name="propertyname"/></returns>
		public Type GetMethodType( string propertyname,Usuarios usuarios)
		{
			// Perform the search for the property's value
			switch (propertyname)
			{
				case "lngIdUsuario":
					return usuarios.lngIdUsuario.GetType();

				case "strLogin":
					return usuarios.strLogin.GetType();

				case "strNombre":
					return usuarios.strNombre.GetType();

				case "strPassword":
					return usuarios.strPassword.GetType();

				case "dtmFechaSistema":
					return usuarios.dtmFechaSistema.GetType();

				case "Excell":
					return usuarios.Excell.GetType();

				case "Modifica_gastos":
					return usuarios.Modifica_gastos.GetType();

				case "Modifica_cd":
					return usuarios.Modifica_cd.GetType();

			}

			return null;
		}
		/// <summary>
		/// update the changes in Usuarios object by passing the object
		/// </summary>
		public bool UpdateChanges(Usuarios usuarios, out string error,Sinapsys.Datos.SQL datosTransaccion=null)
		{
			if (usuarios.OldUsuarios == null)
			{
				    error = "No tiene objeto con el cual comparar";
				    return false;
			}
			string[] Fields = usuarios.FieldChanged();
			error = "";
			return LiqViajes_Bll_Data.DataProvider.UpdateFieldsbyObject(Fields, usuarios, out error,datosTransaccion);
		}
	}

	#endregion

}
