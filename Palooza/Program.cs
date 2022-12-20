using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {
      const int dias = 4;
      string[] Entradas = {"GENERAL", "PREFERENCIAL", "VIP", "PREMIUM", "FAN"};
      int[] Precios = {3500, 6700, 10000, 15000, 25000};
      int dni = 0;
      int dia = 0;
      string tipoEntrada = "";
      int cantEntradas = 0;
      int posicion = 0; //esta posición me servirá para poder encontrar la posición que comparten ambos arrays
      // de entradas y precios y así poder mostrarlos con la misma posición. 
      int MasGasto = 0;
      int dniMasGasto = 0;
      //Lectura adelantada
      Console.WriteLine("Ingrese su DNI:");
      dni = int.Parse(Console.ReadLine());

      while(dni != -1){

         dia = PedirDia(dia);
         posicion = BusquedayValidarEntrada(Entradas, tipoEntrada);
         cantEntradas = PedirCantidad(cantEntradas);
         Console.WriteLine(dni + " gastó " + Precios[posicion] * cantEntradas + " para " + cantEntradas + " entrada/s " + Entradas[posicion] + " para el día " + dia);
         
                if(Precios[posicion] * cantEntradas > MasGasto){
                dniMasGasto = PersonaMasGasto(MasGasto, dniMasGasto, posicion, cantEntradas, Precios, dni);
                  if(dniMasGasto == dni){
                    MasGasto = Precios[posicion] * cantEntradas;
         }  
          Console.WriteLine("Ingrese su DNI");
          dni = int.Parse(Console.ReadLine());
      }
          Console.WriteLine("La persona que más gastó hasta ahora es " + dniMasGasto + " cuyo gasto es de " + MasGasto);
    } 
          static int PedirDia(int dia){
              Console.WriteLine("Ingrese el día al que asiste:");
              dia = int.Parse(Console.ReadLine());
                  while(dia < 1 || dia > 4){
                    Console.WriteLine("Error. Ingrese un día válido:");
                    dia = int.Parse(Console.ReadLine());
      }
            return dia;
    }
          static int BusquedayValidarEntrada(string[] Entradas, string tipoEntrada){ 
          //FUNCIÓN QUE BUSCA LA ENTRADA EN EL ARRAY PARA VER SI LA ENCUENTRA Y ES VÁLIDA. DEVUELVE LA POSICIÓN EN DÓNDE ESTÁ. SINO, ES -1.
              Console.WriteLine("Ingrese el tipo de entrada:");
              tipoEntrada = Console.ReadLine().ToUpper();
              int posicion = -1;
              int idEntrada = 0;
              bool aparecio = false;

                while(idEntrada < Entradas.Length && !aparecio){

                    if(tipoEntrada == Entradas[idEntrada]){

                    posicion = idEntrada;
                    aparecio = true;
          }
          idEntrada++;
        }
                  while (posicion==-1){
                  Console.WriteLine("Error. Ingresar un tipo de entrada válido.");
                  posicion = BusquedayValidarEntrada(Entradas, tipoEntrada);
        }
          return posicion;
    }
        static int PedirCantidad(int cantEntradas){
          Console.WriteLine("Ingrese la cantidad de entradas:");
          cantEntradas = int.Parse(Console.ReadLine());
        
              while(cantEntradas < 1 || cantEntradas > 4){
                Console.WriteLine("Error, ingrese una cantidad de entradas válida.");
                cantEntradas = int.Parse(Console.ReadLine());
          }
          return cantEntradas;
      }

      static int PersonaMasGasto(int MasGasto, int dniMasGasto, int posicion, int cantEntradas, int[] Precios, int dni){

              if(Precios[posicion] * cantEntradas > MasGasto){

                  MasGasto = Precios[posicion] * cantEntradas;
                  dniMasGasto = dni;
            }
             return dniMasGasto;
      }
    }      
  }

}

