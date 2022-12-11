using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {
        
        static void Cargar(string[] Nombres, int[] Sueldos){

            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado "+(i+1)+": ");
                Nombres[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el sueldo "+(i+1)+": ");
                Sueldos[i] = int.Parse(Console.ReadLine());
            }

       }
       static void MayorSueldo(string[] Nombres, int[] Sueldos){

           int mayor;
            int pos;
            mayor = Sueldos[0];
            pos = 0;
            for (int i = 1; i < Nombres.Length; i++)
            {
                if (Sueldos[i] > mayor)
                {
                    mayor = Sueldos[i];
                    pos = i;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + Nombres[pos]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
       }
        
        static void Main(string[] args)
        {

            string[] Nombres = new string[5];
            int[] Sueldos = new int[5];
            Cargar(Nombres, Sueldos);
            MayorSueldo(Nombres, Sueldos);
          
        }   
        }
}

    

    

