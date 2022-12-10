using Internal;
using System;

namespace HelloWorld
{
  class Program
  {

    static void Main(string[] args)
    {

      int dniQueSePatinoTodo = 0;
      int dia1Recaudacion = 0;
      int dia2Recaudacion = 0;
      int promedioPorPersona = 0;
      int entradaGeneral = 0;
      int entradaPreferencial = 0;
      int entradaVip = 0;
      int entradaPremium = 0;
      int entradaFan = 0;
      int entradasEfectivo = 0;
      int entradasTarjeta = 0;



    string[] VecEntradas = {"GENERAL","PREFERENCIAL","VIP","PREMIUM","FAN"};
    int[] VecPrecios =  {3500,6700,10000,15000,25000};
    int[] NumDia = {1,2};
    string [, ] nombre = new string {2, 2 } {"E", "Efectivo" } {"T", "Tarjeta"};
    int[] Ventas = {dni, nNumDia, TipoEntrada, CantEntradas, FormaDepago};

    Ventas[i] = Console.ReadLine();

for (int i = 0; i < Ventas.Length; i++)
      {
        if ((Ventas[i].CantEntradas * VecPrecios[Ventas[i].TipoEntrada]) > dniQueSePatinoTodo)
            dniQueSePatinoTodo = Ventas[i].CantidadEntradas * VecPrecios[TipoEntrada];

      }

    }
  }
}