using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {

    static string[] IngresarModelos(string msj){

    Console.WriteLine(msj);
   
    string[] Modelos = new string[10];
        
        for (string i = 0; i < Modelos.Length; i++)
        {
            Modelos[i] = Console.ReadLine();
        }  

    foreach(string modelo in Modelos){

        Console.WriteLine(modelo);
    }
        return Modelos;
    }


        static void Main(string[] args)

        {
            string[] ModelosIngreados = IngresarModelos("Ingresar 10 modelos de autos");
        }   
        }
    }



        

