using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoMSDN1
{
    public class Reto1
    {
        public static List<Persona> OrdenarLista(List<Persona> listaInicial)
        {
            if (listaInicial == null)
            {
                return null;
            }

            List<Persona> listaDevolver = listaInicial.OrderByDescending(x => x.Edad).ThenBy(x => x.Nombre).ToList();

            return listaDevolver;
        }
        
    }
}
