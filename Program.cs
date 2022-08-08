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
   
            int[] NumerosAIngresar = new int[20];

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

        static List<int> DevolverPares(int[] arrayNums){

            List<int> pares = new List<int>();

            foreach(var item in arrayNums){
                if (item%2 == 0) {
                    pares.Add(item);
                }
            }
            return pares;
        }


        static List<int> Ma5yM30(int[] arrayNums, int x, int y){
            
            List<int> May5yMen30 = new List<int>();

            foreach(var item in arrayNums){

                if (item < x && item > y){

                    Ma5yM30.Add(item);
                }

            }

            return Ma5yM30;
        }


        static void Main(string[] args)
        {

            int[] NumerosIngresados = IngresarNumeros("Ingresa 20 números");
            
            int NumMayor = DevolverMayor(NumerosIngresados);
            Console.WriteLine("El numero mayor es: " + NumMayor);

            

            List<int> NumsPares = DevolverPares(NumerosIngresados);
            
            foreach(int par in NumsPares)
                {
                    Console.WriteLine("El número par es: " + par);
                }


            List<int> Condiciones = Ma5yM30(NumerosIngresados, 5, 30);

            foreach(int nums in Condiciones)
                {
                    Console.WriteLine("El número par es: " + nums);
                }
          
        }   

        }
    }
}


