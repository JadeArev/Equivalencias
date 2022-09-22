using System;
using System.Collections.Generic;
using System.Linq;


namespace HelloWorld
{
  class Program
  {
    
      static int[] ListarNumeros(string msj){

        Console.WriteLine(msj);

        int[] ListaNumeros = new int[5];

        for(  int i = 0; i < ListaNumeros.Length; i++){


          ListaNumeros[i] = int.Parse(Console.ReadLine());

        }


        Console.WriteLine("Los números de la lista son: ");

        foreach(var num in ListaNumeros){

          Console.WriteLine(num);
        }

        return ListaNumeros;

      }

    
      static void IngresarPosiciones(string msj){

        Console.WriteLine(msj);


          int posicion1 = int.Parse(Console.ReadLine());
          int posicion2 = int.Parse(Console.ReadLine());

          if (posicion1 > 20 || posicion2 > 20){

            Console.WriteLine("No se puede ingresar un número mayor a 20 posiciones");
          }

          else{

            Console.WriteLine("La primera posición es: " + posicion1);
            Console.WriteLine("La segunda posición es: " + posicion2);

          }
        
        
      }





    static void Main(string[] args)
    {
      
      int[] Numeros = ListarNumeros("Ingresar 5 números");
      IngresarPosiciones("Ingrese 2 posiciones");

    }
  }
}

