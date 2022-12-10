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


        static void NombreyDinero(string[] Nombres, int[] Dinero){

            for(int nombre = 0; nombre < Nombres.Length; nombre++){

                Console.WriteLine("Ingresa tu nombre");
                Nombres[nombre] = Console.ReadLine();            
            }

            for(int dinero = 0; dinero < Nombres.Length; dinero++){
                Console.WriteLine("Ingrese la cantidad de dinero:");
                Dinero[dinero] = int.Parse(Console.ReadLine());
            }
           
        }


        static string[] MasDineroxCurso(int Cursos, string[] Nombres){



           
        }

        static void Main(string[] args)

        {
            int Cursos = 4;
            int TotalAlumnos = EstudiantesXCurso(Cursos);
            string[] Nombres = new string[TotalAlumnos];
            int[] Dinero = new int[TotalAlumnos];
            NombreyDinero(Nombres, Dinero);
            string[] AlumnoMasPlataPuso = MasDineroxCurso(Cursos, Nombres);
            
        }   
        }
    }
