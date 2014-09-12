using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoMSDN1
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Persona personaComparar = obj as Persona;
            if (personaComparar == null)
            {
                return false;
            }

            return this.Nombre == personaComparar.Nombre && this.Edad == personaComparar.Edad;
        }

        public override int GetHashCode()
        {
            return Tuple.Create(this.Edad, this.Nombre).GetHashCode();
        }
    }
}
