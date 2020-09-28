using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria4
{
    class Cadeteria
    {
        private string nombre;
        private List<Cadete> cadetes;

        public Cadeteria(string nombre)
        {
            this.Nombre = nombre;
            this.Cadetes = new List<Cadete>();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }
    }
}
