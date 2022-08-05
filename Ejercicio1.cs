using System;

namespace Vectores1
{
    class Program
    {

        static int IngresoNumeros()
        {

            int[] NumerosAIngresar = new int[20];

            for (int i = 0; i < NumerosAIngresar.Length; i++)

            {
                Console.WriteLine("Ingrese 20 números");

                NumerosAIngresar[i] = int.Parse(Console.ReadLine());


                return NumerosAIngresar;
            }
        }


        static void Main(string[] args)
        {
            int[] Numeros = IngresoNumeros();
            int NumeroMayor;
            int[] Pares;
            int[] Condiciones;

           
        }
    }
}
