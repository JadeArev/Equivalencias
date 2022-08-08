using System;
using System.Linq;

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


        static int[] DevolverPares(int [] arrayNums){

            

        }

        static void Main(string[] args)
        {

            int[] NumerosIngresados = IngresarNumeros("Ingresa 5 números");
            
            int NumMayor = DevolverMayor(NumerosIngresados);
            Console.WriteLine("El numero mayor es: " + NumMayor);

        }
    }
}


