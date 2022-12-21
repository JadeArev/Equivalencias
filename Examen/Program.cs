using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {       
        static void Main(string[] args){
            string[] Nombres = {"JADE", "LUCAS", "CATALINA", "ZOMMER", "VICKY", "JANA", "ARIEL", "LOLA"};
            int[] Abonos = {1, 2, 3, 4, 5};
            int[] Precios = {50, 100, 150, 200, 250};
            int cantidad = 0;
            string nombre = "";
            string[] Descripcion = {"5GB", "10GB", "15GB", "20GB", "20GB"};
            int abono = 0;
            int posicionNombre = 0;
            int posicionAbono = 0;
            int descontado = 0;
            int comision = 0;
            int total = 0;
            int ticket = 0;
            const int abonos = 5;
            int[] cantidadabonosvendidos = new int[abonos] {0,0,0,0,0};
            int max = 0;
            int abonomasvendido = 0;


                Console.WriteLine("Ingrese el nombre:");
                nombre = Console.ReadLine().ToUpper();
        
            while(nombre != "*"){
                ticket = 0;

                posicionNombre = BusquedayValidar(Nombres, nombre);
                while(posicionNombre==-1){
                  Console.WriteLine("Error. Ingresar un nombre válido.");
                  posicionNombre = BusquedayValidar(Nombres, nombre);
                }
                
                    comision = pedirComision(comision);
                    posicionAbono = BusquedayValidarAbono(Abonos, abono);
                    while(posicionAbono == -1){
                        Console.WriteLine("Error. Ingresar un abono válido");
                        posicionAbono = BusquedayValidarAbono(Abonos, abono);
                    }
                
                        cantidad = PedirCantidad(cantidad);
                
                descontado = ((Precios[posicionAbono] * cantidad) * comision) / 100;
                ticket = Precios[posicionAbono] * cantidad;
                Console.WriteLine(nombre + " abona " + Precios[posicionAbono] * cantidad + " por el abono " + Abonos[posicionAbono] + " cuyo plan es " + Descripcion[posicionAbono]);

                total += ticket;
                Console.WriteLine("El vendedor recibirá " + descontado);

                cantidadabonosvendidos = MasVendidas(posicionAbono, cantidad, cantidadabonosvendidos);
    
            
                Console.WriteLine("Ingrese el nombre:");
                nombre = Console.ReadLine();
            }

            Console.WriteLine("La recaudación total es " + total);

            for(int i = 0; i < cantidadabonosvendidos.Length; i++){
                Console.WriteLine("La cantidad de abonos vendidos para el tipo " + Abonos[i] + " es " + cantidadabonosvendidos[i]);
            }

            for(int i = 0; i < cantidadabonosvendidos.Length; i++){
            if(cantidadabonosvendidos[i] > max){
              max = cantidadabonosvendidos[i];
              abonomasvendido = Abonos[i];
            }
        }
            Console.WriteLine("La entrada más vendida es " + abonomasvendido + " cuya cantidad es " + max);
    
        }

        static int BusquedayValidar(string[] array, string input){ 
          //FUNCIÓN QUE BUSCA LA ENTRADA EN EL ARRAY PARA VER SI LA ENCUENTRA Y ES VÁLIDA. DEVUELVE LA POSICIÓN EN DÓNDE ESTÁ. SINO, ES -1. 
            input = Console.ReadLine().ToUpper();
            int posicion = -1;
            int id = 0;
            bool aparecio = false;

            while(id < array.Length && !aparecio){
                if(input == array[id]){
                    posicion = id;
                    aparecio = true;
                }
                id++;
            }
            return posicion;  
        }
        static int BusquedayValidarAbono(int[] array, int input){ 
          //FUNCIÓN QUE BUSCA LA ENTRADA EN EL ARRAY PARA VER SI LA ENCUENTRA Y ES VÁLIDA. DEVUELVE LA POSICIÓN EN DÓNDE ESTÁ. SINO, ES -1.
            Console.WriteLine("Ingrese el abono");
            input = int.Parse(Console.ReadLine());
            int posicion = -1;
            int id = 0;
            bool aparecio = false;

            while(id < array.Length && !aparecio){
                if(input == array[id]){
                    posicion = id;
                    aparecio = true;
                }
                id++;
            }
            return posicion;  
        }
        static int PedirCantidad(int cantidad){
            Console.WriteLine("Ingrese la cantidad de abonos");
            cantidad = int.Parse(Console.ReadLine());

                while(cantidad < 0){
                    Console.WriteLine("Error. Elija una cantidad válida");
                    cantidad = int.Parse(Console.ReadLine());
                }
            return cantidad;
        }
        static int pedirComision(int comision){
            Console.WriteLine("Ingrese el porcentaje de su comisión");
            comision = int.Parse(Console.ReadLine());
                while(comision < 0){
                    Console.WriteLine("Error. Ingrese un porcentaje válido");
                }
            return comision;
        }

        static int[] MasVendidas(int posicionAbono, int cantidad, int[] cantidadabonosvendidos){

         cantidadabonosvendidos[posicionAbono] += cantidad;
          return cantidadabonosvendidos;
      }   
    }   
}
