using System;

namespace Sinapsys.Datos
{
	/// <summary>
	/// Descripción breve de SQLException.
	/// </summary>
	public class SQLException : System.Exception
	{
		public SQLException() :base()
		{}

		public SQLException(string Mensaje) :base(Mensaje)
		{}

		public SQLException(string Mensaje,System.Exception ExcepcionInterna) :base(Mensaje,ExcepcionInterna)
		{}
	}
}
