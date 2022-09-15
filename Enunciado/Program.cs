using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
  class Program
  {
    

    static string IngresarPalabra(string msj){


    Console.WriteLine(msj);

    string NuevaPalabra = Console.ReadLine();

    Console.WriteLine("La palabra ingresada es : " + NuevaPalabra);

    return NuevaPalabra;

    }



    static void Main(string[] args)
    {
      
      string Palabra = IngresarPalabra("Ingrese una palabra");

    }
  }
}

