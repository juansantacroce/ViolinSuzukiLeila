using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzukiLeila
{
    internal abstract class Persona
    {
		private string nombre;
		private string apellido;
		private string calle;
		private int altura;
		private int id_ciudad;
		private DateTime fecha_alta;
		private string obvservaciones;
		private int dni;

		public int pDni
		{
			get { return dni; }
			set { dni = value; }
		}


		public string pObservaciones
		{
			get { return obvservaciones; }
			set { obvservaciones = value; }
		}


		public DateTime pFecha_alta
		{
			get { return fecha_alta; }
			set { fecha_alta = value; }
		}


		public int pId_ciudad
		{
			get { return id_ciudad; }
			set { id_ciudad = value; }
		}


		public int pAltura
		{
			get { return altura; }
			set { altura = value; }
		}

		public string pCalle
		{
			get { return calle; }
			set { calle = value; }
		}

		public string pApellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public string pNombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

	}
}
