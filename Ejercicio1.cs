using System;

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


        static void Main(string[] args)
        {


            int[] NumerosIngresados = IngresarNumeros("Ingresa 5 números");
        }
    }
}





