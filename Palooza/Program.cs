﻿using Internal;
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

      //Lectura adelantada
      Console.WriteLine("Ingrese su DNI:");
      dni = int.Parse(Console.ReadLine());

      while(dni != -1){

         dia = PedirDia(dia);
         posicion = BusquedayValidarEntrada(Entradas, tipoEntrada);
         cantEntradas = PedirCantidad(cantEntradas);

  
      
        Console.WriteLine("Ingrese su DNI");
        dni = int.Parse(Console.ReadLine());
      }
    } 
    static int PedirDia(int dia){
        Console.WriteLine("Ingrese el día al que asiste:");
        dia = int.Parse(Console.ReadLine());
          while(dia < 0 || dia > 4){
            Console.WriteLine("Ingrese un día válido:");
            dia = int.Parse(Console.ReadLine());
      }
      return dia;
    }
    static int BusquedayValidarEntrada(string[] Entradas, string tipoEntrada){

        Console.WriteLine("Ingrese el tipo de entrada:");
        tipoEntrada = Console.ReadLine();
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
             Console.WriteLine("Error. Ingresar otro.");
             Console.WriteLine("Ingresar el tipo de entrada:");
             tipoEntrada = Console.ReadLine();
             posicion = BusquedaEntrada(Entradas, tipoEntrada);
        }
          return posicion;
    }

      static int PedirCantidad(int cantEntradas){
        Console.WriteLine("Ingrese la cantidad de entradas:");
        cantEntradas = int.Parse(Console.ReadLine());
      }

      
    }    
     
  }
