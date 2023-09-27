using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzukiLeila
{
    internal class Responsable : Persona
    {
		private int id_responsable;

		public int pId_responsable
		{
			get { return id_responsable; }
			set { id_responsable = value; }
		}

		private int id_tipo_responsable;

		public int pId_tipo_responsable
		{
			get { return id_tipo_responsable; }
			set { id_tipo_responsable = value; }
		}

	}
}
