using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {
      const int dias = 4;
      int[] Precios = {3500, 6700, 10000, 15000, 25000};
      string[] Entradas = {"GENERAL", "PREFERENCIAL", "VIP", "PREMIUM", "FAN"};
      
      int[] CantEntradasVendidas = new int[5] {0,0,0,0,0};
      int[] RecaudacionXDia = new int[dias] {0,0,0,0}; //NO puedo sumarle cosas al NULL PORQUE NO EXISTE Y POR ESO LO INICIALIZO.
      
      int dni = 0;
      int dia = 0; //otra opción : int dni, dia, cantEntradas, PrecioEntrada = 0;
      string tipoEntrada = "";
      int cantEntradas = 0;
      int PrecioEntrada = 0; //Lo uso para poder guardar y mostrar el elemento que coincida con la misma posición del array de entradas.

      IngresarVentas(dni, dia, tipoEntrada, cantEntradas, Precios, Entradas, PrecioEntrada, RecaudacionXDia, CantEntradasVendidas);
    }
    //no es necesario hacer una función para ingresar las cosas. Puedo hacerlo directo en el main.
    static void IngresarVentas(int dni, int dia, string tipoEntrada, int cantEntradas, int[]Precios, string[] Entradas, int PrecioEntrada, int[] RecaudacionXDia, int[] CantEntradasVendidas){
        int MasGasto = 0;   
        int dniMasGasto = 0;
        int posicion = 0;
      
        Console.WriteLine("Ingrese su DNI");
        dni = int.Parse(Console.ReadLine());
       
        while(dni != -1){

        Console.WriteLine("Ingrese al día al que asiste:");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tipo de entrada:");
        tipoEntrada = Console.ReadLine().ToUpper();
        Console.WriteLine("Ingrese la cantidad de entradas:");
        cantEntradas = int.Parse(Console.ReadLine());

        for(int i = 0; i < Entradas.Length; i++){

          if(tipoEntrada == Entradas[i]){

            PrecioEntrada = Precios[i];
          }
        }

         if(PrecioEntrada * cantEntradas > MasGasto){
          MasGasto = PrecioEntrada * cantEntradas;
          dniMasGasto = dni;
         }

        Console.WriteLine(dni + " gastó " + PrecioEntrada * cantEntradas + " pesos por " + cantEntradas + " entrada/s " + tipoEntrada + " para el día " + dia);        
        RecaudacionXDia = RecaudacionPorDia(RecaudacionXDia, PrecioEntrada, cantEntradas, dia);
         posicion = Posicion(tipoEntrada, Entradas);
        CantEntradasVendidas = MasVendidas(posicion, cantEntradas, CantEntradasVendidas);
        //
        Console.WriteLine("Ingrese su DNI");
        dni = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("la persona que más gastó hasta ahora es " + dniMasGasto + " cuyo gasto fue de " + MasGasto);

        for(int i = 0; i < RecaudacionXDia.Length; i++){
          Console.WriteLine("La recaudación por el día " + (i+1) + " es de " + RecaudacionXDia[i]);
        }
        for(int i = 0; i < CantEntradasVendidas.Length; i++){
          Console.WriteLine("La cantidad de entradas vendidas para el tipo " + Entradas[i] + " es " + CantEntradasVendidas[i]);
        }        
      }
      static int[] RecaudacionPorDia(int[] RecaudacionXDia, int PrecioEntrada, int cantEntradas, int dia){

        int recaudacion = PrecioEntrada * cantEntradas;

        RecaudacionXDia[dia-1] += recaudacion;
      

          return RecaudacionXDia;
      }
      static int Posicion(string tipoEntrada, string[] Entradas){

          int posicion = -1;
          int i = 0;
          bool aparecio = false;

        while(i < Entradas.Length && !aparecio){

          if(tipoEntrada == Entradas[i]){

            posicion = i;
            aparecio = true;
          }
          i++;
        }
          return posicion;
      }
      static int[] MasVendidas(int posicion, int cantEntradas, int[] CantEntradasVendidas){

         CantEntradasVendidas[posicion] += cantEntradas;
          return CantEntradasVendidas;
      }
      }
    }
  
