using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {
      string[] Entradas = {"GENERAL", "PREFERENCIAL", "VIP", "PREMIUM", "FAN"};

      string tipoEntrada = "";
      int posicion = -1;

        Console.WriteLine("Ingresar tipo entrada:");
        tipoEntrada = Console.ReadLine();
        posicion = ValidarEntrada(tipoEntrada, Entradas);


        while  (posicion==-1){
             Console.WriteLine("Error. Ingresar otro.");

            Console.WriteLine("Ingresar tipo entrada:");
            tipoEntrada = Console.ReadLine();
            posicion = ValidarEntrada(tipoEntrada, Entradas);

        }
        //----- ya se que no es un error porque salio del ciclo comparado con -1

        while  (tipoEntrada != "ZZZ"){
            posicion = ValidarEntrada(tipoEntrada, Entradas);

            if (posicion==-1){
                Console.WriteLine("Error. Ingresar otro.");
            } else {
                // proceso todo lo que tengo procesar
                Console.WriteLine("la posicion de " + tipoEntrada + " es: " + posicion);
            }
            Console.Write("Ingresar tipo entrada: ");
            tipoEntrada = Console.ReadLine();
        }

        //------ sali del ciclo, NO porque lo encontre, sino porque me indicaron ZZZ
    }  
    static int ValidarEntrada(string tipoEntrada, string[] Entradas){

          int posicion = -1;
          int idEntrada = 0;
          bool aparecio = false;

        while((idEntrada < Entradas.Length && !aparecio)){

          if(tipoEntrada == Entradas[idEntrada]){

            posicion = idEntrada;
            aparecio = true;
          }
          idEntrada++;
        }
        return posicion;
    }
    }
}