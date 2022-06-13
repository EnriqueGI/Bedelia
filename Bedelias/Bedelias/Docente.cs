using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedelias
{
    class Docente : Persona
    {
        static int pos = 0;
        private int grado;
        private Materia[] materiasDocente = new Materia[5];
        public int Grado {
            get {
                return this.grado;
            }
            set {
                this.grado = value;
            }
        }


        public void CargarMteria(Materia m) {
            this.materiasDocente[pos] = m;
            pos++;
        }
        public Materia[] listaMaterias()
        {
            return this.materiasDocente;
        }
    }
}
