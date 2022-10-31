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



      static void IngresarPosiciones(int[] Numeros, int posicion1, int posicion2){


        if(posicion1 >= 5 || posicion2 >= 5){

          Console.WriteLine("Se alcanzó la máxima cantidad de números");

        }

      }


      static void MostrarPosiciones(int[] Numeros, int posicion1, int posicion2){


        Console.WriteLine("Los números son:");
        Console.WriteLine(Numeros[posicion1]);
        Console.WriteLine(Numeros[posicion2]);

      }


      static int Promedio(int[] Numeros){
        
        int Suma = 0;
      

        for(int i = 0; i < Numeros.Length; i++) {

            Suma += Numeros[i];

        }

        Console.WriteLine(Suma);

          return Suma;

      }
      

    static void Main(string[] args)
    {


      int[] Numeros = ListarNumeros("Ingresar 5 números");


      Console.WriteLine("siguiente, ingrese dos posiciones");

      int posicion1 = int.Parse(Console.ReadLine());
      int posicion2 = int.Parse(Console.ReadLine());

  
     IngresarPosiciones(Numeros, posicion1, posicion2); 


     MostrarPosiciones(Numeros, posicion1, posicion2);


     int ListaPromedio = Promedio(Numeros);
    

    }
  }
}

