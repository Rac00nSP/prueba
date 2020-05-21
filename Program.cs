using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace Pruebaa
{
    class Program
    {
        private static readonly string username = "admin";
        private static readonly string pass = "123";
        private static int exitCode = 0;
        private static readonly ArrayList _motocicletas = new ArrayList();
        static void Main(string[] args)


        {
            const int intentosMaximos = 3;
            int intentosRealizados = 0;
            while (true)
            {
                intentosRealizados++;
                // Pedimos el username
                Console.WriteLine("Ingrese el nombre de usuario:");
                string tmpUsername = Console.ReadLine();

                // Pedimos la contraseña
                Console.WriteLine("Ingrese la contraseña:");
                string tmpPass = Console.ReadLine();

                // Hacemos la llamada al método Login para saber si es un usuario válido
                if (Login(tmpUsername, tmpPass))
                    IniciarMenuPrincipal();
                else
                {
                    Console.WriteLine("El usuario y/o la contraseña son incorrectos. Intentelo de nuevo.");
                    if (intentosRealizados >= intentosMaximos) Environment.Exit(exitCode);
                    break;
                }
            }
            static bool Login(string username, string pass)
            {
                return Program.username == username && Program.pass == pass;
            }

            static void IniciarMenuPrincipal()
            {


                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("bienvenido a la app de motocicletas");
                    Console.WriteLine("1.-Ingresar motocicleta");
                    Console.WriteLine("2.-Listar motocicletas");
                    Console.WriteLine("3.-Salir");
                    string input = Console.ReadLine();
                    int opcion;
                    if (int.TryParse(input, out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese numero de motor:");
                                string idMotor = Console.ReadLine();

                                Console.WriteLine("ingrese el tipo de motor:");
                                Console.WriteLine("1. dos tiempos");
                                Console.WriteLine("2. cuatro tiempos");
                                TipoMotor tipoMotor = Console.ReadLine() == "1" ?
                                    TipoMotor.CUATRO_TIEMPOS : TipoMotor.DOS_TIEMPOS;

                                Console.WriteLine("Ingrese la cilindrada");
                                int cilindrada = int.Parse(Console.ReadLine());

                                Console.WriteLine("ingrese el año");
                                int ano = int.Parse(Console.ReadLine());

                                Console.WriteLine("ingrese la marca");
                                string marca = Console.ReadLine();

                                Console.WriteLine("ingreese el kilometraje");
                                int kilometraje = int.Parse(Console.ReadLine());

                                Motocicleta motocicleta = new Motocicleta(idMotor, tipoMotor, cilindrada,
                                                                          marca, ano, kilometraje);
                                _motocicletas.Add(motocicleta);



                                break;

                            case 2:
                                if (_motocicletas.Count > 0)
                                    foreach (Motocicleta tmpMotocicleta in _motocicletas)
                                    {
                                        Console.WriteLine("ID del motor: " + tmpMotocicleta.Motor.Id);
                                        Console.WriteLine("Tipo del motor: " + tmpMotocicleta.Motor.TipoMotor);
                                        Console.WriteLine("Cilindrada: " + tmpMotocicleta.Motor.Cilindrada);
                                        Console.WriteLine("Estado del motor: " + tmpMotocicleta.Motor.Estado + "%");
                                        Console.WriteLine("Marca: " + tmpMotocicleta.Marca);
                                        Console.WriteLine("Año: " + tmpMotocicleta.Ano);
                                        Console.WriteLine("Kilometraje: " + tmpMotocicleta.Kilometraje);
                                        Console.WriteLine("______________________________________________");
                                        Console.WriteLine(string.Empty);
                                    }
                                else
                                    Console.WriteLine("No hay motocicletas registradas.");
                                Console.WriteLine("* Presione cualquier tecla para continuar *");
                                Console.ReadLine();
                                break;

                            case 3:
                                // Salir del programa
                                if (exitCode == 0)
                                    Console.WriteLine("La aplicación finalizó correctamente.");
                                else
                                    Console.WriteLine("Hubo errores al finalizar el programa.");
                                Environment.Exit(exitCode); // Equivalencia en java: System.exit(0);

                                break;

                            default:

                                break;
                        }


                        Console.WriteLine("Hello World!");
                    }
                    else Console.WriteLine("No ingreso uno de los numero entero pedidos");


                }
            }

        }
    }
}
