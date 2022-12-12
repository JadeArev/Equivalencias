using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {
        static void IngresarAlumnos(int Cursos){

            int CantAlumnos;
            int Total = 0;
            int Promedio = 0;
    
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
                Total += RecaudacionXCurso(Cursos, Dinero, CantAlumnos);
            }
            Console.WriteLine("La recaudación total entre todos es " + Total);
            Console.WriteLine("El promedio de dinero es " + Promedio);
;        }
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
        static int RecaudacionXCurso(int Cursos, int[] Dinero, int CantAlumnos){

            int CantCurso = 0;
            int Promedio = 0;

            for(int i = 0; i < Dinero.Length; i++){

                CantCurso += Dinero[i];
            }
                Promedio = CantCurso/CantAlumnos;

                Console.WriteLine("La cantidad recaudada en total en este curso es " + CantCurso);
                Console.WriteLine("El promedio recaudado en este curso es " + Promedio);
                
            return CantCurso;
        }
        static void Main(string[] args){
            int Cursos = 4;
            IngresarAlumnos(Cursos);
        }
    }
}



