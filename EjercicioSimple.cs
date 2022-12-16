using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {
      string[] Entradas = {"GENERAL", "PREFERENCIAL", "VIP", "PREMIUM", "FAN"};

      string tipoEntrada = "";

        posicion = ValidarEntrada(Entradas, tipoEntrada);
        Console.WriteLine(posicion);
    }  
    static int ValidarEntrada(string tipoEntrada, string[] Entradas){

        tipoEntrada = Console.ReadLine();

        int posicion = -1;
          int idEntrada = 0;
          bool aparecio = false;

        while(i < Entradas.Length && !aparecio){

          if(tipoEntrada == Entradas[i]){

            posicion = idEntrada;
            aparecio = true;
          }
          i++;
        }
        return posicion;
    }
    }
}
  