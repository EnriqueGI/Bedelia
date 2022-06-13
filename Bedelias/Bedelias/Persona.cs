using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bedelias
{
    class Persona
    {
        private int cedula;
        private String nombre;
        private int edad;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cedula { get => cedula; set => cedula = value; }
    }
}
