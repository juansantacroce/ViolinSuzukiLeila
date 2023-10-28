using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzukiLeila
{
    internal class Parametro
    {
		private string nombre;
		private object valor;

        public Parametro(string Nombre, object Valor)
        {
			nombre = Nombre;
			valor = Valor;
        }

        public object pValor
		{
			get { return valor; }
			set { valor = value; }
		}

		public string pNombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

	}
}
