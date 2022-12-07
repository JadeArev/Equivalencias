using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {

    static void IngresarModelos(string msj, string[] Modelos){

        Console.WriteLine(msj);
   
        for (int modelo = 0; modelo < Modelos.Length; modelo++)
        {
            Modelos[modelo] = Console.ReadLine();
        }  

        foreach(string modelo in Modelos){
        Console.WriteLine(modelo);
        }
    }

        static void Arreglar(int Dias, int Arreglos){

            

        }

        static void Main(string[] args)

        {
            int totalTrabajos = 0;
            int Dias = 6;
            int Arreglos = 8;
            string[] ModelosIngresados = new string[10];
            IngresarModelos("Ingresar 10 modelos de autos", ModelosIngresados);
            Arreglar(Dias, Arreglos);
        }   
        }
    }



        

