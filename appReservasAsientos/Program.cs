using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appReservasAsientos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            String[,] Asientos = new string[10, 10];
            Boolean Capacidad = true;
            Boolean Reiniciar = true;


            Int32 fila = 0;
            Int32 Columna = 0;

            //Cargamos la matriz con todos los lugares Libres
            CargarAsientosLibres();

            //Comienzo del programa 
            Console.WriteLine("Bienvenido al sistema de reservas ");

            while (Reiniciar == true)
            {
                // Estructura repetitiva central del programa 
                try
                {
                    


                    while (Capacidad == true)
                    {
                        
                        //Visualizacion Mapa
                        Console.WriteLine("Quiere visualizar los asientos Disponibles?. Ingrese si para visualizar  u oprima una tecla en casi negativo ");
                        if (Console.ReadLine().ToLower() == "si")
                        {


                            CheckCapacidadCompleta();
                            VisualizarAsientosLibres();
                            Reserva();





                        }
                        else
                        {
                            CheckCapacidadCompleta();
                            Reserva();

                        }


                    }



                }
                catch (FormatException )
                {
                    Reiniciar = true;
                    Console.WriteLine("Por favor no ingrese letras, solo se acepta el rango de numeros indicados. Oprima enter para continuar ");
                    Console.ReadLine();
                    

                }
            }
           




            //Procedimiento para cargar todos los asientos libres
            void CargarAsientosLibres()
            {
                for (int f = 0; f < 10; f++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        Asientos[f, c] = "L";
                    }
                }

            }
            //Procedimiento para visualizar los asientos disponibles mediante un mapeo de la matriz
            void VisualizarAsientosLibres()
            {


                Console.WriteLine(("Matriz:") + "\t");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write((i) + "\t");
                    for (int j = 0; j < 10; j++)
                    {

                        Console.Write("[" + Asientos[i, j] + "]" + "\t");
                    }
                    Console.WriteLine(); // Nueva línea para la siguiente fila.
                }








            }
            // Procimiento que maneja las reservas 
            void Reserva()
            {


                //Reserva
                Boolean Controlador = false;
                while (Controlador != true)
                {
                    Console.WriteLine("Ingrese fila y asiento a reservar");
                    Console.WriteLine("Ingrese una fila : entre 0 y 9 ");
                    fila = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese un asiento: entre 0 y 9 ");
                    Columna = Convert.ToInt32(Console.ReadLine());

                    if (fila >= 0 && fila <= 9)
                    {
                        if (Columna >= 0 && Columna <= 9)
                        {
                            Controlador = true;
                        }
                        else
                        {
                            Console.WriteLine("Numero de asiento no es valido, revise y vuelva a intentar");
                            Console.WriteLine("");

                        }
                    }
                    else
                    {
                        Console.WriteLine("Numero de fila no es valido, revise y vuelva a intentar");
                        Console.WriteLine("");
                    }
                }


                if (Asientos[Convert.ToInt32(fila), Convert.ToInt32(Columna)] == "L")
                {
                    Asientos[Convert.ToInt32(fila), Convert.ToInt32(Columna)] = "R";
                    Console.WriteLine("La reserva del asiento en la fila " + fila + " numero  " + Columna + " fue exitosa");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("El asiento seleccionado esta ocupado . por favor elija otro");


                }
                Console.WriteLine("Desea realizar otra reserva ?. Ingese si para continuar u oprima una tecla en casi negativo ");
                if (Console.ReadLine().ToLower() != "si")
                {
                    Console.WriteLine("Gracias por su tiempo que tenga un excelente dia . Oprima una tecla para salir. Saludos  ");
                    Console.ReadLine();
                    Capacidad = false;
                    Reiniciar = false;
                    Environment.Exit(0);


                }





            }
            //Procedimiento para hacer el check de la capacidad de la sala 
            void CheckCapacidadCompleta()
            {
                for (int f = 0; f < 10; f++)
                {
                    for (int c = 0; c < 10; c++)
                    {
                        if (Asientos[f, c] != "R")
                        {

                            Capacidad = true;
                        }
                        else
                        {
                           
                            Capacidad = false;
                           
                        }
                    }
                }
                if (Capacidad== false)
                {
                    Console.WriteLine("Capacidad de la sala completa , no se pueden realizar reservas, intente otro dia .Oprima una tecla para saluir. Saludos...");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

        }
    }
}
                                
                            
                        
                        
                    
                
            
        
    


           

            