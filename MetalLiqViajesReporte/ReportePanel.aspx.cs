using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;


namespace MetalLiqViajesReporte
{
    public partial class ReportePanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string MapUrlPath = HttpContext.Current.Server.MapPath("PDF") + "\\";
            if (!IsPostBack)
            {
                if (Request.QueryString["PDF"] != null)
                {
                    bool pdf = false;
                    pdf = Request.QueryString["PDF"] == "0";

                    string filename = Request["nombrereporte"] + ".pdf";
                    if (filename == null)
                        filename = "ReporteViajes.pdf";

                    string nameUrl = "http://" + HttpContext.Current.Request.Url.Host + HttpContext.Current.Request.ApplicationPath + "//ReporteViajes01.aspx";
                    string sFile = Server.MapPath("PDF") + "\\" + filename ;
                    LiqViajes_Bll_Data.UtilPdf.PasarPDF(nameUrl, sFile);

                    this.Iframe1.Attributes.Add("src", "pdf/" + filename + "#toolbar=1&navpanes=1&scrollbar=1&view=fit");
                }

            }
        }
    }
}