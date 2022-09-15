using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
  class Program
  {
    

    static string IngresarNumeros(string msj){


    Console.WriteLine(msj);

    int[] Numeros = int.Parse(Console.ReadLine());

    Console.WriteLine("La palabra ingresada es : " + NuevaPalabra);

    return NuevaPalabra;

    }



    static void Main(string[] args)
    {
      
      int[] NumerosIngresados = IngresarNumeros("Ingrese 20 números");

    }
  }
}

