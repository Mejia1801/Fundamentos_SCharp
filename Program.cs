using System;


namespace Programacion_Estructurada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tipo de dato y nombre de variables, se agrego un limite con un arrays
            int limite = 10;
            var cerverza = new string[limite];
            int iCerveza = 0;
            int opciones = 0;


            // se agrego un login que pide contraseña
            if (Autentificate())
            {
                //do while nos ayuda a que el programa sea repetitivo hasta que el usuario le de salir
                do
                {


                    try
                    {
                        //Console.Clear(); ayuda a que todo se quede limpie afecta en las posiciones que lo coloques
                        //mandamos a llamar el metodo menu y su opcion a elegir

                        Console.WriteLine("Ingresa el numero de la opcion que quieras realizar");
                        Menu();
                        opciones = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Error: no se permite letras");
                        continue; // Ayuda que aparezca el msj de catch y no de default que se encuentra dentro de swtich

                    }




                    switch (opciones)

                    {

                        case 1:
                            //dentro del if usamos la logica que solo puede guardar al limite que se le dio al arrays
                            if (iCerveza < limite)
                            {
                                Console.Clear();
                                Console.WriteLine("Escribe el nombre de una cerveza: ");
                                //guarda el nombre de la cerveza al mismo tiempo ayuda a sumar el conteo 
                                cerverza[iCerveza] = Console.ReadLine();
                                iCerveza++;
                                Console.Clear();


                            }
                            else
                            {
                                Console.WriteLine("Ya no puede ingresar mas cervezas");
                            }
                            break;

                        case 2:
                            //mandamos a llamar el metodo menu vista que por dentro tiene parametros
                            MenuVista(cerverza, iCerveza);
                            break;

                        case 3:
                            //opcion de salir
                            Console.WriteLine("Gracias por tu participacion!");
                            break;

                        default:
                            Console.WriteLine("Opción no valida, vuelve a elegir uno de las 3 opciones asignadas");
                            break;

                    }
                    //si es diferente a 3 finaliza el programa
                } while (opciones != 3);

            }


        }
        //metodo de autentificacion con true o falso o boleano
        static bool Autentificate()
        {
            //damos a conocer el tipo de dato y nombre de las variables
            int intento = 0;
            int limiteIntento = 3;

            //usamos while porque nos ayuda a saber que va ser repetitivo 
            //damos a conocer los limites
            while (intento < limiteIntento)
            {

                Console.WriteLine("Intento " + (intento + 1) + " de " + limiteIntento + ". Ingrese su contraseña:");


                try
                {

                    int contraseña = Convert.ToInt32(Console.ReadLine());

                    //la condicion if si la contraseña es igual pueden ingresar al menu
                    if (contraseña == 123)
                    {

                        Console.WriteLine("Correcto, Acceso Permitido");
                        Console.Clear();
                        return (true);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Contraseña Incorrecto");

                    }
                }
                catch (Exception) // Capturar el error si la entrada no es un número
                {
                    Console.Clear();
                    Console.WriteLine("Error: la contraseña debe ser un número.");

                }
                //inicializamos dentro de while pero fuera de if
                intento++;
            }
            //cuando llega al limite termina la ejecucion
            Console.WriteLine("Pues valio Chetos");
            return (false);
        }

        //metodo menu
        static void Menu()
        {
            Console.WriteLine("1. Agregar Nombre");
            Console.WriteLine("2. Mostrar Nombre");
            Console.WriteLine("3. Salir");

        }
        //metodo vista con (parametros)
        static void MenuVista(string[] cerveza, int iCerveza)
        {

            Console.WriteLine("-----------Cerveza-----------");
            //bucle for para poder mostrar lo que llevamos guardado
            //i < iCerveza para mostrar las cervezas existentes
            for (int i = 0; i < iCerveza; i++)

            {
                Console.WriteLine("La cerveza numero " + (i + 1) + " es: " + cerveza[i]);
            }
            //truco para retornar
            Console.WriteLine("Presiona una tecla para continuar");
            //especificamos que continue con el proceso
            Console.ReadLine();
            Console.Clear();
        }

    }
}
