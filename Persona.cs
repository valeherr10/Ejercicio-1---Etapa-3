using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Etapa_3
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string direccion;
        private int celular;
        private List<Persona> personas;

        public Persona(int id, string nombre, string direccion, int celular)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.celular = celular;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public string getNombre()
        {
            return nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getDireccion()
        {
            return direccion;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public int getCelular()
        {
            return celular;
        }
        public void setCelular(int celular)
        {
            this.celular = celular;
        }



        public Persona()
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
        public void registar(int id, string nombre, string direccion, int celular)
        {
            Persona busqueda = buscar(id);
            if (busqueda == null)
            {
                Persona nuevo = new Persona(id, nombre, direccion, celular);
                personas.Add(nuevo);
            }
        }




    }
}
