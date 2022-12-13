using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {
      int[] Precios = {3500, 6700, 10000, 15000, 25000};
      string[] Entradas = {"GENERAL", "PREFERENCIAL", "VIP", "PREMIUM", "FAN"};
      
      int dni = 0;
      int dia = 0;
      string tipoEntrada = "";
      int cantEntradas = 0;
      int MasGasto = 0;
      int dniMasGasto = 0;
      int PrecioEntrada = 0;

      IngresarVentas(dni, dia, tipoEntrada, cantEntradas, Precios, Entradas, PrecioEntrada);
    }
    static void IngresarVentas(int dni, int dia, string tipoEntrada, int cantEntradas, int[]Precios, string[] Entradas, int PrecioEntrada){

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

          Console.WriteLine(dni + " gastó " + PrecioEntrada + " pesos por entrada " + tipoEntrada);

        //Acá llamó funciones
          }
        }
        Console.WriteLine("Ingrese su DNI");
        dni = int.Parse(Console.ReadLine());
        }
      }
    }
  }
