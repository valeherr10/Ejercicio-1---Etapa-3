using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___Etapa_3
{
    public class Pelicula
    {
        private int id;
        private string nombre;
        private string genero;
        private int duracion;
        private double precio;
        private List<Pelicula> peliculas;
        
        public Pelicula(int id, string nombre, string genero, int duracion, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.genero = genero;
            this.duracion = duracion;
            this.precio = precio;
        }

        public Pelicula()
        {
            peliculas = new List<Pelicula>();

            peliculas.Add(new Pelicula(1, "Harry Potter y la piedra filosofal", "Fantasia", 152, 15500));
            peliculas.Add(new Pelicula(2, "Avenger: Endgame", "Superheroes", 182, 20500));
            peliculas.Add(new Pelicula(3, "Mortal Kombat", "Fantasia", 110, 10000));
            peliculas.Add(new Pelicula(4, "Animales fantasticos y donde encontrarlos", "Fantasia", 133, 15500));
            peliculas.Add(new Pelicula(5, "Mision imposible 4", "Accion", 133, 20000));
            peliculas.Add(new Pelicula(6, "Mision imposible 5", "Accion", 131, 20000));
            peliculas.Add(new Pelicula(7, "Hombres de negro: internacional", "Ciencia ficcion", 115, 12000));
            peliculas.Add(new Pelicula(8, "Spiderman: sin regreso a casa", "Superheroes", 148, 30000));
            peliculas.Add(new Pelicula(9, "La la land", "Musical", 128, 15000));
            peliculas.Add(new Pelicula(10, "High school musical 1", "Musical", 98, 10000));
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
        public string getGenero()
        {
            return genero;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public int getDuracion()
        {
            return duracion;
        }
        public void setDuracion(int duracion)
        {
            this.duracion = duracion;
        }

        public Pelicula consultar(int id)
        {
            Pelicula busqueda = null;
            bool encontrar = false;

            for (int i = 0; i < peliculas.Count && encontrar == false; i++)
            {
                if (peliculas[i].getId() == id)
                {
                    busqueda = peliculas[i];
                    encontrar = true;
                }
            }

            return busqueda;
        }

      


    }
}
