using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzukiLeila
{
    internal class alumnos : Persona
    {
        private int id_alumno;
        private DateTime fec_nac;
        private string colegio;

        public int pId_alumno
        {
            get { return id_alumno; }
            set { id_alumno = value; }
        }

        public string pColegio
        {
            get { return colegio; }
            set { colegio = value; }
        }

        public DateTime pFec_nac
        {
            get { return fec_nac; }
            set { fec_nac = value; }
        }
    }
}
