using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiqViajes_Bll_Data
{
    public partial class RegistroViajeDTO
    {
        public long IdRegistro { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public bool Liquidado { get; set; }
        public string Placa { get; set; }
        public string NitConductor { get; set; }
        public string NombreConductor { get; set; }
        public decimal ValorGastos { get; set; }
        public decimal ValorAnticipos { get; set; }
        public decimal ValorSaldo { get; set; }
    }
}
