using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Etapa_3
{
    public class Tienda
    {
        private List<Persona> personas;

        public Tienda()
        {
            personas = new List<Persona>();

        }
        public Persona buscar(int id)
        {
            Persona busqueda = null;
            bool encontrar = false;

            for (int i = 0; i < personas.Count && encontrar == false; i++)
            {
                if (personas[i].getId() == id)
                {
                    busqueda = personas[i];
                    encontrar = true;
                }
            }

            return busqueda;
        }
        public void registrar(int id, string nombre, string direccion, int celular)
        {
            Persona busqueda = buscar(id);
            if (busqueda == null)
            {
                Persona nuevo = new Persona(id, nombre, direccion, celular);
                personas.Add(nuevo);
            }
        }

        public void cobrar(double precio)
        {


        }
    }
}
