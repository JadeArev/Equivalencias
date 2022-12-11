using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {
        static void IngresarAlumnos(int Cursos){

            int alumnos = 0;

            for(int curso = 0; curso < Cursos; curso++){

                Console.WriteLine("Ingrese la cantidad de alumnos para el curso "+(curso+1)+": ");
                alumnos = int.Parse(Console.ReadLine());
            }
        }
    
           static void Main(string[] args){
            int Cursos = 4;
            IngresarAlumnos(Cursos);
        }
    }
}  


