using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    class Program
    {

        static int[] IngresarNumeros(string msj)
        {

            Console.WriteLine(msj);
   
            int[] NumerosAIngresar = new int[5];

            for (int i = 0; i < NumerosAIngresar.Length; i++)

            {
                NumerosAIngresar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Los números son: ");

            foreach (var item in NumerosAIngresar)
                Console.WriteLine(item);

            return NumerosAIngresar;

        }

        static int DevolverMayor(int[] arrayNums){

                int NumMayor = arrayNums.Max();
                

                return NumMayor;

        }

        static List<int> DevolverPares(int [] arrayNums){

            List<int> pares = new List<int>();

            foreach(var item in arrayNums){
                if (item%2 == 0) {
                    pares.Add(item);
                }
            }
            return pares;
        }

        static void Main(string[] args)
        {

            int[] NumerosIngresados = IngresarNumeros("Ingresa 5 números");
            
            int NumMayor = DevolverMayor(NumerosIngresados);
            Console.WriteLine("El numero mayor es: " + NumMayor);

            List<int> NumsPares = DevolverPares(NumerosIngresados);
            
            foreach(int par in NumsPares)
                {
                    Console.WriteLine("El número par es: " + par);
                }

        }
    }
}


