using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalLiqViajes_Forms.Util
{
    public class ExcelTerpel
    {
        public long Recibo { get; set; }//No.Venta 
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public string NombreCliente { get; set; }
        public string Estacion { get; set; }
        public string TipoEstacion { get; set; }
        public string Destinatario { get; set; }
        public string Ciudad { get; set; }
        public long IdEDS { get; set; }
        public string Placa { get; set; }
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }
        public double Precio { get; set; }
        public double TotalVentas { get; set; }
        public double PrecioEspecial { get; set; }
        public double TotalFactura { get; set; }
        public decimal Descuento { get; set; }
        public string UnidadVenta { get; set; }
        public decimal Kilometraje { get; set; }
        public string TipoVenta { get; set; }
        public string Factura { get; set; }

    }
    
    public class FileExcel
    {
        public string nameFile { get; set; }
        public string GetFullPath { get; set; }
        public bool Excluir { get; set; }
        public string Notaexcluir { get; set; }
        public bool Importado { get; set; }

    }
}
