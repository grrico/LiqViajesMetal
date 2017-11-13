using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalLiqViajes_Forms
{
    public class UtiliDRegistro
    {
        public UtiliDRegistro()
        {
            idRegistro = 0;
        }
        public long idRegistro { get; set; }
    }


    public class UtilPlaca
    {
        public UtilPlaca()
        {
            Placa = "";
        }
        public string Placa { get; set; }
    }

    public class UtilYear
    {
        public UtilYear()
        {
            YearId = 0;
            YearName = "";
        }
        public int YearId { get; set; }
        public string  YearName { get; set; }
    }


    public class UtilMonth
    {
        public UtilMonth()
        {
            MonthId = 0;
            MonthName = "";
        }
        public int MonthId { get; set; }
        public string MonthName { get; set; }
    }

    public class Conductor
    {
        public decimal Cedula { get; set; }
        public string NombreConductor { get; set; }
        public string Placa { get; set; }
        public Decimal ValorAnticipo { get; set; }
        public Decimal ValorGastos { get; set; }
        public Decimal ValorTotal { get; set; }
    }

    public class Providedor
    {
        public string Nombre { get; set; }        
    }
}
