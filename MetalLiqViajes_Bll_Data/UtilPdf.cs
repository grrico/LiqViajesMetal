using EO.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LiqViajes_Bll_Data
{
    public static class UtilPdf
    {
        public static string GenerarPdf(string outputFileName, string nameUrl, bool merge, string IdentificacionCliente, string codigoproceso, string sMedida, System.Collections.ArrayList arrayList,
            string prefijo, bool m_Header, bool m_Footer, ref int cantidadPaginas,
            bool numerarfolio, ref int contadorpaginas, int codigoreporte, string textoEncabezado, string textoPie, string[] margen)
        {
            try
            {
                bool autoFitWidth = false;

                EO.Pdf.Runtime.AddLicense(
                "vPwBFPGe6sUF6KFwprbH2rFpqLqzy/We6ff6Gu12mbmzy653hI6xy59Zs/f6" +
                "Eu2a6/kDEL1+qrfYHbKc7rkFE8uvzvXGDPecrN346Lx1pvf6Eu2a6/kDEL1G" +
                "gcDAF+ic3PIEEL1GgXXj7fQQ7azcwp61n1mXpM0X6Jzc8gQQyJ21ucXcsW+w" +
                "usbhsmaowMAX6Jzc8gQQyJ21kZvLn1mXwP0U4p7l9/YQvXWm8PoO5Kfq6fbp" +
                "jEOXpLHLu5rj8AAivUaBpLHLn1mXpLHn4J3bpAUk7560ptb6rYnb6rPL9Z7p" +
                "9/oa7XaZtcfZr1uXs8+4iVmXpLHnrprj8AAivUaBpLHLn3Xm9vUQ8YLl6gDL" +
                "45rr6c7NtmipusDdr2qqprEe9Ju8");

                //Get the Url
                string url = nameUrl;
                if (url.Trim() == string.Empty)
                    return "No llego la url";

                HtmlToPdf.Options.PageSize = new SizeF(8.5f, 13);  //pageSize;
                if (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyGroupSeparator == ".")
                {
                    for (int i = 0; i < margen.Length; i++)
                    {
                        margen[i] = margen[i].Replace('.', ',');
                    }
                }
                if ((codigoreporte == 16) || (codigoreporte == 11))
                {
                    if (outputFileName.Contains("_err_"))
                    {
                        HtmlToPdf.Options.PageSize = new SizeF(8.5f, 11f);  //pageSize;
                    }
                }
                float marginTop = float.Parse(margen[0]);
                if (m_Header)
                    marginTop = float.Parse(margen[4]);

                float marginBottom = float.Parse(margen[1]);
                if (m_Footer)
                    marginBottom = float.Parse(margen[5]);

                float marginLeft = float.Parse(margen[2]);
                float marginRight = float.Parse(margen[3]);

                //Set page layout arguments
                HtmlToPdf.Options.StartPageIndex = 0;
                HtmlToPdf.Options.StartPosition = 0;
                EO.Pdf.HtmlToPdf.Options.OutputArea = new RectangleF(marginLeft, marginTop, EO.Pdf.HtmlToPdf.Options.PageSize.Width - marginLeft - marginRight, EO.Pdf.HtmlToPdf.Options.PageSize.Height - marginTop - marginBottom);
                EO.Pdf.PdfDocument documentoPdf = new EO.Pdf.PdfDocument();
                if (autoFitWidth)
                {
                    HtmlToPdf.Options.AutoFitX = HtmlToPdfAutoFitMode.ShrinkToFit;
                }
                if (m_Header)
                {
                    if (!outputFileName.Contains("_err_"))
                    {
                        HtmlToPdf.Options.HeaderHtmlFormat = textoEncabezado;
                    }
                }
                if (m_Footer)
                {
                    if (!outputFileName.Contains("_err_"))
                    {
                        HtmlToPdf.Options.FooterHtmlFormat = textoPie;
                    }
                }
                if (!merge)
                {
                    EO.Pdf.HtmlToPdf.Options.FooterHtmlPosition = HtmlToPdf.Options.PageSize.Height - 1.2f;
                    EO.Pdf.HtmlToPdfResult result = EO.Pdf.HtmlToPdf.ConvertUrl(nameUrl, documentoPdf);
                    EO.Pdf.HtmlElement[] elements = result.HtmlDocument.GetElementsByClassName("TituloCapitulo");
                    //Create a bookmark for each of these elements
                    foreach (EO.Pdf.HtmlElement element in elements)
                    {
                        if (!element.IsVisible)
                            continue;
                        //Create the bookmark
                        EO.Pdf.PdfBookmark bookmark = element.CreateBookmark();
                        documentoPdf.Bookmarks.Add(bookmark);
                    }

                    if (File.Exists(outputFileName))
                        File.Delete(outputFileName);
                    string ApplicationPath = HttpContext.Current.Request.ApplicationPath;
                    string savePath = System.Web.HttpContext.Current.Server.MapPath(ApplicationPath + "\\pdf\\" + outputFileName);

                    // si numerarfolio = true enmuera las paginas dél pdf, la numeracion se asigna por el contador que le llega del paquete.
                    if (numerarfolio)
                    {
                        for (int i = 0; i < documentoPdf.Pages.Count; i++)
                        {
                            PdfPage page = documentoPdf.Pages[i];
                            contadorpaginas++;
                            //HtmlToPdf.Options.OutputArea = new RectangleF(0f, 1f, 1f, 2f);
                            HtmlToPdf.Options.OutputArea = new RectangleF(6.5f, 0.5f, 1f, 2f);
                            HtmlToPdf.ConvertHtml(string.Format(@"<div style="" font-size: 34px; text-align: right;"">" + contadorpaginas.ToString() + "</div>", i + 1, documentoPdf.Pages.Count), page);
                        }
                    }

                    if (outputFileName.Length < 64000000)
                    {
                        documentoPdf.Save(savePath);
                        cantidadPaginas = documentoPdf.Document.Pages.Count;
                    }
                }
                else
                {
                    //Load the PDF files
                    PdfDocument doc1;
                    documentoPdf = new PdfDocument(arrayList[0].ToString());//Saca el primero

                    for (int i = 1; i < arrayList.Count; i++)
                    {
                        doc1 = new PdfDocument(arrayList[i].ToString());//  Lee el pdf
                        documentoPdf = PdfDocument.Merge(documentoPdf, doc1);
                    }

                    outputFileName = prefijo + "_" + IdentificacionCliente + ".pdf";
                    if (File.Exists(outputFileName))
                        File.Delete(outputFileName);
                    if (outputFileName.Length < 64000000)
                    {
                        string ApplicationPath = HttpContext.Current.Request.ApplicationPath;
                        string savePath = System.Web.HttpContext.Current.Server.MapPath(ApplicationPath + "\\pdf\\" + outputFileName);
                        documentoPdf.Save(savePath);
                        cantidadPaginas = documentoPdf.Document.Pages.Count;
                    }
                }

                return "";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string GenerarOtroPdf(string outputFileName, string nameUrl)
        {
            try
            {
                bool autoFitWidth = false;
                //Get the Url
                EO.Pdf.PdfDocument documentoPdf = new EO.Pdf.PdfDocument();
                string url = nameUrl;
                if (url.Trim() == string.Empty)
                    return "No llego la url";

                EO.Pdf.Runtime.AddLicense(
                "vPwBFPGe6sUF6KFwprbH2rFpqLqzy/We6ff6Gu12mbmzy653hI6xy59Zs/f6" +
                "Eu2a6/kDEL1+qrfYHbKc7rkFE8uvzvXGDPecrN346Lx1pvf6Eu2a6/kDEL1G" +
                "gcDAF+ic3PIEEL1GgXXj7fQQ7azcwp61n1mXpM0X6Jzc8gQQyJ21ucXcsW+w" +
                "usbhsmaowMAX6Jzc8gQQyJ21kZvLn1mXwP0U4p7l9/YQvXWm8PoO5Kfq6fbp" +
                "jEOXpLHLu5rj8AAivUaBpLHLn1mXpLHn4J3bpAUk7560ptb6rYnb6rPL9Z7p" +
                "9/oa7XaZtcfZr1uXs8+4iVmXpLHnrprj8AAivUaBpLHLn3Xm9vUQ8YLl6gDL" +
                "45rr6c7NtmipusDdr2qqprEe9Ju8");

                //SizeF pageSize = new SizeF(8.5f, 13.02f);
                SizeF pageSize = new SizeF(94.5f, 113.02f);
                bool logo = true;

                float marginTop = float.Parse(1.ToString());
                if (logo)
                    marginTop += float.Parse(0.51.ToString());

                float marginBottom = float.Parse(0.51.ToString());

                float marginLeft = float.Parse(0.11.ToString());
                float marginRight = float.Parse(0.11.ToString());

                //Set page layout arguments
                EO.Pdf.HtmlToPdf.Options.PageSize = pageSize;
                EO.Pdf.HtmlToPdf.Options.OutputArea = new RectangleF(marginLeft, marginTop, pageSize.Width - marginLeft - marginRight, pageSize.Height - marginTop - marginBottom);
                if (autoFitWidth)
                {
                    HtmlToPdf.Options.AutoFitX = HtmlToPdfAutoFitMode.ShrinkToFit;
                }

                if (logo)
                {

                    string encabezado = "<div style=\"padding-left: 1px;\">";
                    encabezado += "<img style=\"padding-left: 1px;\" src=\"http://www.sistecredito.com/juridicoReportes/images/LogoCompleto.png\" />";
                    encabezado += "</div>";
                    EO.Pdf.HtmlToPdf.Options.OutputArea = new RectangleF(marginLeft, marginTop - 1.9f, pageSize.Width - marginLeft - marginRight, pageSize.Height - marginTop - marginBottom);
                    //Setting header and footer format
                    HtmlToPdf.Options.HeaderHtmlFormat = encabezado;
                }
                EO.Pdf.HtmlToPdf.Options.FooterHtmlPosition = HtmlToPdf.Options.PageSize.Height - 1.2f;
                EO.Pdf.HtmlToPdfResult result = EO.Pdf.HtmlToPdf.ConvertUrl(nameUrl, documentoPdf);
                EO.Pdf.HtmlElement[] elements = result.HtmlDocument.GetElementsByClassName("TituloCapitulo");
                //Create a bookmark for each of these elements
                foreach (EO.Pdf.HtmlElement element in elements)
                {
                    if (!element.IsVisible)
                        continue;

                    //Create the bookmark
                    EO.Pdf.PdfBookmark bookmark = element.CreateBookmark();
                    documentoPdf.Bookmarks.Add(bookmark);
                }

                if (File.Exists(outputFileName))
                    File.Delete(outputFileName);
                string ApplicationPath = HttpContext.Current.Request.ApplicationPath;
                string savePath = System.Web.HttpContext.Current.Server.MapPath(ApplicationPath + "\\pdf\\" + outputFileName);

                if (outputFileName.Length < 64000000)
                {
                    documentoPdf.Save(savePath);
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string MergePdf(System.Collections.ArrayList arrayList, string prefijo, string IdentificacionCliente, ref int cantidadPaginas,
            ref string errorReporte)
        {
            try
            {
                errorReporte = "";
                EO.Pdf.Runtime.AddLicense(
                "vPwBFPGe6sUF6KFwprbH2rFpqLqzy/We6ff6Gu12mbmzy653hI6xy59Zs/f6" +
                "Eu2a6/kDEL1+qrfYHbKc7rkFE8uvzvXGDPecrN346Lx1pvf6Eu2a6/kDEL1G" +
                "gcDAF+ic3PIEEL1GgXXj7fQQ7azcwp61n1mXpM0X6Jzc8gQQyJ21ucXcsW+w" +
                "usbhsmaowMAX6Jzc8gQQyJ21kZvLn1mXwP0U4p7l9/YQvXWm8PoO5Kfq6fbp" +
                "jEOXpLHLu5rj8AAivUaBpLHLn1mXpLHn4J3bpAUk7560ptb6rYnb6rPL9Z7p" +
                "9/oa7XaZtcfZr1uXs8+4iVmXpLHnrprj8AAivUaBpLHLn3Xm9vUQ8YLl6gDL" +
                "45rr6c7NtmipusDdr2qqprEe9Ju8");

                PdfDocument doc1;
                PdfDocument documentoPdf = new PdfDocument();  // = new PdfDocument(arrayList[0].ToString());//Saca el primero
                //Load the PDF files
                for (int i = 0; i < arrayList.Count; i++)
                {
                    try
                    {
                        string iNameFilePdf = arrayList[i].ToString();
                        doc1 = new PdfDocument(iNameFilePdf);//  Lee el pdf
                        documentoPdf = PdfDocument.Merge(documentoPdf, doc1);
                    }
                    catch (Exception ex)
                    {
                        errorReporte = ex.Message;
                        return ex.Message;
                    }
                }
                string ApplicationPath = "";
                string savePath = "";
                string outputFileName = prefijo + "_" + IdentificacionCliente + ".pdf";
                if (File.Exists(outputFileName))
                    File.Delete(outputFileName);
                if (outputFileName.Length < 64000000)
                {
                    ApplicationPath = HttpContext.Current.Request.ApplicationPath;
                    savePath = System.Web.HttpContext.Current.Server.MapPath(ApplicationPath + "\\pdf\\" + outputFileName);
                    documentoPdf.Save(savePath);
                    cantidadPaginas = documentoPdf.Document.Pages.Count;
                    return savePath;
                }
                return "";
            }
            catch (Exception ex)
            {
                errorReporte = ex.Message;
                return ex.Message;
            }
        }

        public static void GenerarReporteEOPDF(string iPagina, string filename)
        {
            try
            {
                EO.Pdf.Runtime.AddLicense(
                "vPwBFPGe6sUF6KFwprbH2rFpqLqzy/We6ff6Gu12mbmzy653hI6xy59Zs/f6" +
                "Eu2a6/kDEL1+qrfYHbKc7rkFE8uvzvXGDPecrN346Lx1pvf6Eu2a6/kDEL1G" +
                "gcDAF+ic3PIEEL1GgXXj7fQQ7azcwp61n1mXpM0X6Jzc8gQQyJ21ucXcsW+w" +
                "usbhsmaowMAX6Jzc8gQQyJ21kZvLn1mXwP0U4p7l9/YQvXWm8PoO5Kfq6fbp" +
                "jEOXpLHLu5rj8AAivUaBpLHLn1mXpLHn4J3bpAUk7560ptb6rYnb6rPL9Z7p" +
                "9/oa7XaZtcfZr1uXs8+4iVmXpLHnrprj8AAivUaBpLHLn3Xm9vUQ8YLl6gDL" +
                "45rr6c7NtmipusDdr2qqprEe9Ju8");


                //string ApplicationPath = HttpContext.Current.Request.ApplicationPath;
                //string pdfFileName = System.Web.HttpContext.Current.Server.MapPath(ApplicationPath + "\\pdf\\" + filename);
                string pdfFileName = string.Format(@"d:\PDFSGenerados\{0}.{1}", filename, "pdf");

                PdfDocumentSecurity security = new PdfDocumentSecurity("1234");

                //Load the PDF file with the given password
                //PdfDocument doc = new PdfDocument(pdfFileName, security);

                PdfDocument doc = new PdfDocument();
                //doc.Security.UserPassword = "1234";
                //doc.Security.OwnerPassword ="1234";

                //ApplicationPath = HttpContext.Current.Request.Url.Authority;

                string m_pagina = iPagina;
                if (iPagina.Contains("localhost"))
                {
                    iPagina = "http://" + iPagina;
                }

                //iPagina = "http://sisteapps2/juridicoReportes/Default.aspx?Proceso=68360";


                string nameUrl = iPagina;// "http://" + ApplicationPath + "/Reportes/" + iPagina + ".aspx?idR=" + resultadoCodigo.ToString();

                doc.Standard = PdfStandard.PDF_A;

                PdfAttachment attachment1 = new PdfAttachment("D:\\img2.jpg");
                doc.Attachments.Add(attachment1);

                //PdfAttachment attachment2 = new PdfAttachment("D:\\video2.mp3");
                //doc.Attachments.Add(attachment2);

                PdfAttachment attachment3 = new PdfAttachment("D:\\video1.mp4");
                doc.Attachments.Add(attachment3);

                HtmlToPdf.Options.PageSize = new SizeF(8.5f, 13.02f);  //pageSize;

                //doc.Pages[0].Size.Height = 13;

                //Add a cookie
                HtmlToPdf.Options.StartPageIndex = 0;
                HtmlToPdf.Options.StartPosition = 0;

                HtmlToPdf.ConvertUrl(iPagina, doc);

                doc.Save(pdfFileName);

            }
            catch (Exception ex)
            {
            }
        }

        public static string MergePdf(System.Collections.ArrayList arrayList)
        {
            EO.Pdf.Runtime.AddLicense(
                "vPwBFPGe6sUF6KFwprbH2rFpqLqzy/We6ff6Gu12mbmzy653hI6xy59Zs/f6" +
                "Eu2a6/kDEL1+qrfYHbKc7rkFE8uvzvXGDPecrN346Lx1pvf6Eu2a6/kDEL1G" +
                "gcDAF+ic3PIEEL1GgXXj7fQQ7azcwp61n1mXpM0X6Jzc8gQQyJ21ucXcsW+w" +
                "usbhsmaowMAX6Jzc8gQQyJ21kZvLn1mXwP0U4p7l9/YQvXWm8PoO5Kfq6fbp" +
                "jEOXpLHLu5rj8AAivUaBpLHLn1mXpLHn4J3bpAUk7560ptb6rYnb6rPL9Z7p" +
                "9/oa7XaZtcfZr1uXs8+4iVmXpLHnrprj8AAivUaBpLHLn3Xm9vUQ8YLl6gDL" +
                "45rr6c7NtmipusDdr2qqprEe9Ju8");


            string result = "pruebas.pdf";
            //Get the file names
            string filePath1 = @"C:\Desarrollo\Sistecredito\Sistedesktop\Juridico\WebReporteJuridico\PDF\25901_9_1128415053.pdf".Trim();
            if ((filePath1 == string.Empty) ||
                !File.Exists(filePath1))
                return "Please enter a valid PDF file path for the first file to be merged.";
            string filePath2 = @"C:\Desarrollo\Sistecredito\Sistedesktop\Juridico\WebReporteJuridico\PDF\25901_9_1128415053.pdf".Trim();
            if ((filePath1 == string.Empty) ||
                !File.Exists(filePath1))
                return "Please enter a valid PDF file path for the second file to be merged.";

            //Load the PDF files
            PdfDocument doc1 = new PdfDocument(filePath1);
            PdfDocument doc2 = new PdfDocument(filePath2);

            //Merge the files
            PdfDocument doc = PdfDocument.Merge(doc1, doc2);

            //You are also free to modify the merged document
            PdfPage page = doc.Pages.Add();
            HtmlToPdf.ConvertHtml("This is the merged version.", page);

            //Save the result
            doc.Save(result);

            return null;
        }

    }


}
