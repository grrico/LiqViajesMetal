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
        public DateTime Fecha { get; set; }//Fecha  - //Hora 
        public string Hora { get; set; }//{Hora}
        public string NombreCliente { get; set; }   //Cliente 
        public string Estacion { get; set; }//{Estacion}
        public string TipoEstacion { get; set; }//{Tipo Estación}
        public string Destinatario { get; set; }//{Destinatari}
        public string Ciudad { get; set; }//{Ciudad}
        public long IdEDS { get; set; }//{ID EDS}
        public string Placa { get; set; }//{Placa}
        public string Producto { get; set; }//{Producto}
        public decimal cantidad { get; set; }//{Cantidad}
        public decimal Precio { get; set; }//{Precio}
        public decimal TotalVentas { get; set; }//{Total Venta}
        public decimal PrecioEspecial { get; set; }//{Precio Especial}
        public decimal TotalFactura { get; set; }//{Total Factura}
        public decimal Descuento { get; set; }//{Descuento}
        public decimal UnidadVenta { get; set; }//{Unidad de Venta}
        public decimal Kilometraje { get; set; }//{Kilometraje}
        public string TipoVenta { get; set; }//{Tipo de Venta}
        public string Factura { get; set; }//{Factura}

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
