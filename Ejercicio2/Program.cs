using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public class Program
    {
        

        static void IngresarNumeros(string msj)
        {
            Console.WriteLine(msj);

            int [] Numeros = new int [10];
            int Pares = 0;
            int Impares = 0;
            int Ceros = 0;
            int PrimerDocena = 0;
            int SegundaDocena = 0;
            int TerceraDocena = 0;

            for (int i = 0; i < Numeros.Length; i++)
            {
                Numeros [i] = int.Parse(Console.ReadLine());
            }
            foreach (int a in Numeros)
            {
                if (EsPar(a) && a < 37)
                    Pares++;
                else if (!EsPar(a) && a < 37)
                    Impares++;
                if (EsCero(a))
                    Ceros++;
                int valorDeDecena = DocenaMiembro(a);
                if (valorDeDecena == 1)
                    PrimerDocena++;
                if (valorDeDecena == 2)
                    SegundaDocena++;
                if (valorDeDecena == 3)
                    TerceraDocena++;
            }

            Console.WriteLine("Los números son: ");
            foreach (var item in Numeros)
                Console.WriteLine(item);
            Console.WriteLine("Se encontraron " + Pares + " numeros pares.");
            Console.WriteLine("Se encontraron " + Impares + " numeros impares.");
            Console.WriteLine("Se encontraron " + Ceros + " numeros iguales a 0.");
            Console.WriteLine("Se encontraron " + PrimerDocena + " igual o menores a 12.");
            Console.WriteLine("Se encontraron " + SegundaDocena + " correspondientes a la segunda docena.");
            Console.WriteLine("Se encontraron " + TerceraDocena + " correspondientes a la tercer docena.");
            
        }



        static bool EsPar(int Numero)
        {
            return Numero % 2 == 0;
        }

        static int DocenaMiembro(int Numero)
        {
            if (Numero <= 12 && Numero < 37)
            {
                return 1;
            }
            if (Numero <= 24 && Numero > 12 && Numero < 37)
            {
                return 2;
            }
            if (Numero <= 36 && Numero > 24 && Numero < 37)
            {
                return 3;
            }
            return 0;
        }

        static bool EsCero(int Numero)
        {
            return Numero == 0;
        }

        public static void Main(string [] args)
        {
            IngresarNumeros("Ingrese 10 números");

        }

    }
}