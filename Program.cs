namespace Ejercicio_1___Etapa_3
{

    // Valentina Herrera Rocha

    class Program
    {
        static void Main(string[] args)
        {

            Persona llevarse = new Persona();
            Pelicula videotienda = new Pelicula();


            int seguir = 1;
            while (seguir == 1)
            {
                Console.WriteLine("************* MENU *************");
                Console.WriteLine(" 1. Registrarse");
                Console.WriteLine(" 2. Ver peliculas");
                Console.WriteLine(" 3. Escribir comentarios");
                Console.Write(" Ingrese el número de la opcion a elegir: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine(" 1. Registrarse");
                            Console.Write(" Ingrese la ID de la persona: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write(" Ingrese el nombre: ");
                            string nombre = Console.ReadLine();
                            Console.Write(" Ingrese la direccion: ");
                            string direccion = Console.ReadLine();
                            Console.Write(" Ingrese el numero de celular: ");
                            int celular = int.Parse(Console.ReadLine());
                            llevarse.registar(id, nombre, direccion, celular);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" 2. Ver peliculas");
                            Console.WriteLine(" 1. Harry Potter y la piedra filosofal. ALQUILER = 15.500 ");
                            Console.WriteLine(" 2. Avenger: Endgame. ALQUILER = 20.500 ");
                            Console.WriteLine(" 3. Mortal Kombat. ALQUILER = 10.000 ");
                            Console.WriteLine(" 4. Animales fantasticos y donde encontrarlos. ALQUILER = 15.500 ");
                            Console.WriteLine(" 5. Mision imposible 4. ALQUILER = 20.000 ");
                            Console.WriteLine(" 6. Mision imposible 5. ALQUILER = 20.000 ");
                            Console.WriteLine(" 7. Hombres de negro: internacional. ALQUILER = 12.000 ");
                            Console.WriteLine(" 8. Spiderman: sin regreso a casa. ALQUILER = 30.000 ");
                            Console.WriteLine(" 9. La la land. ALQUILER = 15.000 ");
                            Console.WriteLine(" 10. High school musical 1. ALQUILER = 10.000 ");

                            Console.Write(" Escriba el numero de la pelicula que desea");
                            int eleccion = int.Parse(Console.ReadLine());

                            if (eleccion == 1)
                            {

                                Console.WriteLine(" Usted ha seleccionado la pelicula -Harry Potter y la piedra filosofal- y debe pagar 15.500 ");
                            }
                            else if (eleccion == 2)
                            {

                                Console.WriteLine(" Usted ha seleccionado la pelicula -Avenger: Endgame- y debe pagar 20.500 ");
                            }
                            else if (eleccion == 3)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -Mortal Kombat- y debe pagar 10.000 ");
                            }
                            else if (eleccion == 4)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -Animales fantasticos y donde encontrarlos- y debe pagar 15.500 ");
                            }
                            else if (eleccion == 5)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -Mision imposible 4- y debe pagar 20.000 ");
                            }
                            else if (eleccion == 6)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -Mision imposible 5- y debe pagar 20.000 ");
                            }
                            else if (eleccion == 7)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -Hombres de negro: internacional- y debe pagar 12.000 ");
                            }
                            else if (eleccion == 8)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -Spiderman: sin regreso a casa- y debe pagar 30.000 ");
                            }
                            else if (eleccion == 9)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -La la land- y debe pagar 15.000 ");
                            }
                            else if (eleccion == 10)
                            {
                                Console.WriteLine(" Usted ha seleccionado la pelicula -High school musical 1- y debe pagar 10.000 ");
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" 3. Escribir comentarios");
                            Console.WriteLine(" Que comentarios/anotaciones tiene sobre la pelicula: ");
                            string anotaciones = Console.ReadLine();

                            break;
                        }
                    default:
                        {
                            Console.Write(" La opción no es valida ");
                            break;
                        }
                }

                Console.WriteLine("\n Si desea volver al menú, escriba 1 ");
                Console.WriteLine(" Si desea cerrar, escriba 2 ");
                seguir = int.Parse(Console.ReadLine());
            }
        }
    }
}

