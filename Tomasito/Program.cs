using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {
        static void IngresarAlumnos(int Cursos){

            int CantAlumnos;
    
            for(int curso = 0; curso < Cursos; curso++){
                Console.WriteLine("Ingrese la cantidad de alumnos en el curso " + (curso+1));
                CantAlumnos = int.Parse(Console.ReadLine());
                string[] Nombres = new string[CantAlumnos];
                int[] Dinero = new int[CantAlumnos];

                    if(curso == 2){
                        CantAlumnos--;
                        Console.WriteLine("Este es el curso sin Tomasito");
                    }

                for(int alumno = 0; alumno < CantAlumnos; alumno++){
                    Console.WriteLine("Ingresa el nombre del alumno " + alumno);    
                    Nombres[alumno] = Console.ReadLine();
                    Console.WriteLine("Ingresa el dinero que va a aportar " + alumno);
                    Dinero[alumno] = int.Parse(Console.ReadLine());

                }
                MasPlata(Dinero, Nombres);
                RecaudacionXCurso(Cursos, Dinero);
            }
        }
        static void MasPlata(int[] Dinero, string[] Nombres){

            string NombreMasPlata = "";
            int MasPlata = 0;

            for(int i = 0; i < Dinero.Length; i++){

                if(Dinero[i] > MasPlata){
                    MasPlata = Dinero[i];
                    NombreMasPlata = Nombres[i];
                }
            }
                Console.WriteLine("el que más plata puso fue " + NombreMasPlata);
        }
        static void RecaudacionXCurso(int Cursos, int[] Dinero){

            int CantCurso = 0;

            for(int i = 0; i < Dinero.Length; i++){

                CantCurso += Dinero[i];
            }
                Console.WriteLine("La cantidad recaudada en total en este curso es " + CantCurso);

                RecaudacionTotal(Cursos, CantCurso);
        }

        static void RecaudacionTotal(int Cursos, int CantCurso){

            int Total = 0;

            for(int i = 0; i < CantCurso; i++){

                Total += CantCurso;
            }
                Console.WriteLine("La recaudación total es " + Total);
        }
        static void Main(string[] args){
            int Cursos = 4;
            IngresarAlumnos(Cursos);

        }
    }
}



