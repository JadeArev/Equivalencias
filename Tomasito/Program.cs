using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {

        static int EstudiantesXCurso(int Cursos){

            int Total = 0;
            int SinTomasito = 0;

            for(int i = 0; i < Cursos; i++){
            
            Console.WriteLine("Ingrese la cantidad de alumnos para el curso");
             int CantEstudiantes = int.Parse(Console.ReadLine());


                Total += CantEstudiantes;
                SinTomasito = Total - 1;
                
            }

            Console.WriteLine("La cantidad de alumnos total es (sin Tomasito):" + SinTomasito);

            return SinTomasito; 
        }


        static void Main(string[] args)

        {
            int Cursos = 4;
           int TotalAlumnos = EstudiantesXCurso(Cursos);
           
        }   
        }
    }
