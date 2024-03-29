﻿using System;

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
      int[] RecaudacionPorDia = new int[dias] {0,0,0,0};
      int[] CantEntradasVendidas = new int[5] {0,0,0,0,0};
      int max = 0;
      string entradamasvendida = "";

      //Lectura adelantada
      Console.WriteLine("Ingrese su DNI:");
      dni = int.Parse(Console.ReadLine());

      while(dni != -1){
         dia = PedirDia(dia);
         posicion = BusquedayValidarEntrada(Entradas, tipoEntrada);
         cantEntradas = PedirCantidad(cantEntradas);

         if(Precios[posicion] * cantEntradas > MasGasto){
                dniMasGasto = PersonaMasGasto(MasGasto, dniMasGasto, posicion, cantEntradas, Precios, dni);
                  if(dniMasGasto == dni){
                    MasGasto = Precios[posicion] * cantEntradas;
         } 
      }
      Console.WriteLine(dni + " gastó " + Precios[posicion] * cantEntradas + " para " + cantEntradas + " entrada/s " + Entradas[posicion] + " para el día " + dia);
        RecaudacionPorDia = RecaudacionXDia(RecaudacionPorDia, Precios, posicion, cantEntradas, dia);
        CantEntradasVendidas = MasVendidas(posicion, cantEntradas, CantEntradasVendidas);
      
        Console.WriteLine("Ingrese su DNI");
          dni = int.Parse(Console.ReadLine());
    } 
        Console.WriteLine("La persona que más gastó hasta ahora es " + dniMasGasto + " cuyo gasto es de " + MasGasto);
          
          for(int i = 0; i < RecaudacionPorDia.Length; i++){
            Console.WriteLine("La recaudación por el día " + (i+1) + " es de " + RecaudacionPorDia[i]);
        }
          for(int i = 0; i < CantEntradasVendidas.Length; i++){
            Console.WriteLine("La cantidad de entradas vendidas para el tipo " + Entradas[i] + " es " + CantEntradasVendidas[i]);
        }

        for(int i = 0; i < CantEntradasVendidas.Length; i++){
            if(CantEntradasVendidas[i] > max){
              max = CantEntradasVendidas[i];
              entradamasvendida = Entradas[i];
            }
        }
        Console.WriteLine("La entrada más vendida es " + entradamasvendida + " cuya cantidad es " + max);

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
    static int[] RecaudacionXDia(int[] RecaudacionPorDia, int[] Precios, int posicion, int cantEntradas, int dia){
      
      int recaudacion = Precios[posicion] * cantEntradas;
        RecaudacionPorDia[dia-1] += recaudacion;
          return RecaudacionPorDia;
    } 

    static int[] MasVendidas(int posicion, int cantEntradas, int[] CantEntradasVendidas){

         CantEntradasVendidas[posicion] += cantEntradas;
          return CantEntradasVendidas;
      }   
  }
}

