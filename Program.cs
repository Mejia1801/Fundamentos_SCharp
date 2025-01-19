using System;


namespace Programacion_Estructurada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limite = 10;
            var cerverza = new string[limite];
            int iCerveza = 0;
            int opciones = 0;
           

            if (Autentificate())
            {

                do
                {
                    Console.Clear();
                    Console.WriteLine("Ingresa el nuemero de la opcion que quieras realizar");
                    Menu();
                    opciones = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (opciones)

                    {

                        case 1:
                            if (iCerveza < limite)
                            {

                                Console.WriteLine("Escribe el nombre de una cerveza: ");
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
                            MenuVista(cerverza, iCerveza);
                            break;

                        case 3:
                            Console.WriteLine("Gracias por tu participacion!");
                            break;

                        default:
                            Console.WriteLine("Opción no valida, vuelve a elegir uno de las 3 opciones asignadas");
                            break;

                    }

                } while (opciones != 3);

            }
           

        }
        static bool Autentificate()
        {
            
            int intento = 0;
            int limiteIntento = 3;

            while (intento < limiteIntento)
            {
                Console.WriteLine("Intento " + (intento + 1) + " de " + limiteIntento + ". Ingrese su contraseña:");
                int contraseña = Convert.ToInt32(Console.ReadLine());

                if (contraseña == 123)
                {
                    Console.WriteLine("Correcto");
                    return (true);
                }
                else 
                {
                    Console.WriteLine("Contraseña Incorrecto");

                }
                intento++;
            }
            Console.WriteLine("Pues valio Chetos");
            return (false);
        }
       
        
        static void Menu()
        {
            Console.WriteLine("1. Agregar Nombre");
            Console.WriteLine("2. Mostrar Nombre");
            Console.WriteLine("3. Salir");

        }
        static void MenuVista(string[] cerveza, int iCerveza)
        {
            
            Console.WriteLine("-----------Cerveza-----------");
            for (int i = 0; i < iCerveza; i++)
            {
                Console.WriteLine("La cerveza numero "+ (i + 1) + " es: " + cerveza[i]);
            }
            Console.WriteLine("Presiona una tecla para continuar");
            //especificamos que continue con el proceso
            Console.ReadLine();
            Console.Clear();
        }

    }
}
