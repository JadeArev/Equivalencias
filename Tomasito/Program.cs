using System;
using System.Linq;
using System.Collections.Generic;

namespace TP1
{
    public static class Program
    {
        static int[] IngresarAlumnos(int Cursos){

            int[] cantAlumnos = new int[Cursos];

            for(int i = 0; i < cantAlumnos.Length; i++){

                Console.WriteLine("Ingrese la cantidad de alumnos para el curso "+(i+1)+": ");
                cantAlumnos[i] = int.Parse(Console.ReadLine());
            }
                return cantAlumnos;
        }
        static void NombreyDinero(string[] Nombres1, string[] Nombres2, string[] Nombres3, string[] Nombres4, int[]Dinero1, int[]Dinero2, int[]Dinero3, int[]Dinero4){

            for (int i = 0; i < Nombres1.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno "+(i+1)+": ");
                Nombres1[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el dinero a poner "+(i+1)+": ");
                Dinero1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < Nombres2.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno "+(i+1)+": ");
                Nombres2[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el dinero a poner "+(i+1)+": ");
                Dinero2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Nombres3.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno "+(i+1)+": ");
                Nombres3[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el dinero a poner "+(i+1)+": ");
                Dinero3[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Nombres1.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno "+(i+1)+": ");
                Nombres4[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el dinero a poner "+(i+1)+": ");
                Dinero4[i] = int.Parse(Console.ReadLine());
            }
            }


        static void MasDineroXCurso(string[] Nombres1, string[] Nombres2, string[] Nombres3, string[] Nombres4, int[]Dinero1, int[]Dinero2, int[]Dinero3, int[]Dinero4){
        

        }
        static void Main(string[] args){
            int Cursos = 4;
            int[] AlumnosXCurso = IngresarAlumnos(Cursos);
            for(int i = 0; i < AlumnosXCurso.Length; i++){
                Console.WriteLine("en el curso "+(i+1) + " hay: " + AlumnosXCurso[i] + " alumnos");
            }
            string[] Nombres1 = new string[AlumnosXCurso[0]];
            string[] Nombres2 = new string[AlumnosXCurso[1]];
            string[] Nombres3 = new string[AlumnosXCurso[2]];
            string[] Nombres4 = new string[AlumnosXCurso[3]];   
            int[] Dinero1 = new int[AlumnosXCurso[0]];
            int[] Dinero2 = new int[AlumnosXCurso[1]];
            int[] Dinero3 = new int[AlumnosXCurso[2]];
            int[] Dinero4 = new int[AlumnosXCurso[3]];
            NombreyDinero(Nombres1, Nombres2, Nombres3, Nombres4, Dinero1, Dinero2, Dinero3, Dinero4);
        }
    }

}



