using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWorld
{
  class Program
  {

    static void Main(string[] args)
    {

        string[] Nombres = {"Jade", "Catalina", "Nicole", "Zommer", "Ariel"};
        int[] Notas = {10, 3, 10, 7, 6};
        string[] Estados = {"EN PROCESO", "BIEN", "NOTABLE", "SOBRESALIENTE"};

        Analizar(Notas, Estados, Nombres);
        

        static void Analizar(int[] Notas, string[] Estados, string[]Nombres){

            string Nota = "";

            for(int nota = 0; nota < Notas.Length; nota++){
            if(Notas[nota] < 5){

                Nota = Estados[0];
            
            Console.WriteLine("El estado de " + Nombres[nota] + " es " + Nota);
            }

            else if(Notas[nota] > 5 && Notas[nota] < 7){

                Nota = Estados[1];
                Console.WriteLine("El estado de " + Nombres[nota] + " es " + Nota);
            }
            else if(Notas[nota] > 7 && Notas[nota] < 9){

                Nota = Estados[2];
                Console.WriteLine("El estado de " + Nombres[nota] + " es " + Nota);
            }

            else if(Notas[nota] < 9 || Notas[nota] <= 10){

                Nota = Estados[3];
                Console.WriteLine("El estado de " + Nombres[nota] + " es " + Nota);
            }

            
        }
        }

    }
  }
}