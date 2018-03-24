using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace LiqMetalDMS_Bll_Data
{
	public interface IBLLObject // : IXmlSerializable
	{
		int GetObjectVersion();
		string GetObjectHash();
		string GetObjectXmlData();
		string GetObjectXmlPartialData();
		void SetObjectXmlData(string xmldata);
		void SetObjectXmlPartialData(string xmldata);
		bool CompareObjectHash(string hash);
	}

    public interface IDTOObject // : IXmlSerializable
    {
        object GetAttribute(string pattribute);
        Type GetAttributeType(string pattribute);
        string GetSqlKey();
        string TableName();
    }

}
