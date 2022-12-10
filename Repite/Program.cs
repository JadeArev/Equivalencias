using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {
        static int[] Array(){

            int[] Numeros = new int[5];

            for(int i = 0; i < Numeros.Length; i++){
            Numeros[i] = int.Parse(Console.ReadLine());
            }

            return Numeros;
        }
        static int MenorElemento(int[] ArrayNumeros){

            int Menor = ArrayNumeros.Min();
            return Menor;
        }
        static int Repite(int Menor, int[]ArrayNumeros){

            int cantidad = 0;

            for(int i = 0; i < ArrayNumeros.Length; i++){

                if(ArrayNumeros[i] == Menor){
                    cantidad++;
                }
            }
            Console.WriteLine("La cantidad de veces que se repite el número menor " + Menor + " es " + cantidad);
            
            return cantidad;
        }

        static int[] Doble(int[] ArrayNumeros){

            for(int i = 0; i < ArrayNumeros.Length; i++){

                ArrayNumeros[i] *= 2;
            }
            
            Console.WriteLine(ArrayNumeros[i]);

            return ArrayNumeros;
        }
        static void Main(string[] args)
        {
            int[] ArrayNumeros = Array();
            int Menor = MenorElemento(ArrayNumeros);
            int cantidad = Repite(Menor, ArrayNumeros);
            int[] Dobles = Doble(ArrayNumeros);
            Console.WriteLine(Dobles);
        }   
    }
}