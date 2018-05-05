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
using Microsoft.Practices.EnterpriseLibrary.Security.Cryptography;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace LiqViajes_Bll_Data
{

	public partial class Rutas : IDTOObject
	{

        private List<RutasAbreviaturas> rutasAbreviaturaList;

        public List<RutasAbreviaturas> RutasAbreviaturaList
        {
            get
            {
                return rutasAbreviaturaList;
            }

            set
            {
                rutasAbreviaturaList = value;
            }
        }

        private string descripcionTramo;
        
        private  string m_TipoTrailerDescripcion;

        public string DescripcionTramo
        {
            get
            {
                descripcionTramo = "";

                if (RutasAbreviaturaList == null)
                    RutasAbreviaturaList = RutasAbreviaturasController.Instance.GetAll();

                string[] iDescripcion = this.m_strRutaAnticipo.Split('-');
                string desRuta="";
                foreach (var item in iDescripcion)
                {
                    desRuta = item.ToString();
                    RutasAbreviaturas abrevuatura = RutasAbreviaturaList.Find(t => t.strAbreviatura == desRuta);
                    if (abrevuatura == null)
                    {
                        abrevuatura = new RutasAbreviaturas();                        
                        abrevuatura.strAbreviatura= desRuta;
                        abrevuatura.strNombreAbreviatura= desRuta;
                        abrevuatura.lngIdAbreviatura =  RutasAbreviaturasController.Instance.Create(abrevuatura).lngIdAbreviatura;
                    }
                    desRuta = abrevuatura.strNombreAbreviatura;
                    if (descripcionTramo == "")
                        descripcionTramo += desRuta;
                    else
                        descripcionTramo += "-" + desRuta;

                }

                return descripcionTramo;
            }
        }

        public string TipoTrailerDescripcion
        {
            get
            {
                return m_TipoTrailerDescripcion = TipoTrailerController.Instance.Get(this.TipoTrailerCodigo.Value).Descripcion;
            }           
        }
               
    }

}
