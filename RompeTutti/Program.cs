using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {

    static void IngresarModelos(string msj, string[] Modelos){

        Console.WriteLine(msj);
   
        for (int i = 0; i < Modelos.Length; i++)
        {
            Modelos[i] = Console.ReadLine();
        }  

        foreach(string modelo in Modelos){
        Console.WriteLine(modelo);
        }
    }

        static void Main(string[] args)

        {
            string[] ModelosIngresados = new string[10];
            IngresarModelos("Ingresar 10 modelos de autos", ModelosIngresados);
        }   
        }
    }



        

