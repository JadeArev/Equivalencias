using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {
        string[] Yates = {"MEGAYATE", "CATAMARAN", "VELERO", "GRANDE", "PEQUEÑO"};
        int[] Precios = {15000, 12000, 9000, 6000, 3000};
        int[] Stock = {25, 20, 15, 10, 5};
        string[] Empleados = {"AREVALOS", "GUTIERREZ", "ZOMMER"};
        int dni = 0;
        string yate = "";
        int posicionYate = 0;
        int posicionEmpleado = 0;
        char formadepago = '\0';
        string empleado = "";
        int totalyate = 0;
        int descontado = 0;
        int[] yatesvendidos = {0,0,0,0,0};
        

        //Lectura adelantada de ciclo
        Console.WriteLine("Ingrese su DNI");
        dni = int.Parse(Console.ReadLine());

            while(dni != 0){
                Console.WriteLine("Ingrese el tipo de yate:");
                posicionYate = BusquedayValidar(Yates, yate);
                Console.WriteLine("Ingrese el empleado:");
                posicionEmpleado = BusquedayValidar(Empleados, empleado);
                formadepago = PedirPago(formadepago);
                totalyate = Precios[posicionYate];
                    if(formadepago == 'E'){
                        descontado = (totalyate * 10) / 100;
                        Console.WriteLine(dni + " abona " + (totalyate - descontado) + " con " + formadepago);
                    }
                    else{
                        Console.WriteLine(dni + " abona " + totalyate + " con " + formadepago);
                    }

                    Stock = StockPorYate(Stock, posicionYate);
                    yatesvendidos = cantidadYatesVendidos(yatesvendidos, posicion);
                
                    Console.WriteLine("Ingrese su DNI");
                    dni = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < Stock.Length; i++){
                Console.WriteLine("El stock para los yates " + Yates[i] + " son " + Stock[i]);
            }
            for(int i = 0; i < yatesvendidos.Length; i++){
                Console.WriteLine("La cantidad de entradas vendidas para el tipo " + Yates[i] + " es " + yatesvendidos[i]);
    }  

            static int BusquedayValidar(string[] array, string input){ 
          //FUNCIÓN QUE BUSCA LA ENTRADA EN EL ARRAY PARA VER SI LA ENCUENTRA Y ES VÁLIDA. DEVUELVE LA POSICIÓN EN DÓNDE ESTÁ. SINO, ES -1.
              input = Console.ReadLine().ToUpper();
              int posicion = -1;
              int id = 0;
              bool aparecio = false;

                while(id < array.Length && !aparecio){
                    if(input == array[id]){
                    posicion = id;
                    aparecio = true;
          }
          id++;
                }
                  while (posicion==-1){
                  Console.WriteLine("Error. Ingrese de nuevo");
                  posicion = BusquedayValidar(array, input);
                  }
                return posicion;  
        }
         static char PedirPago(char formadePago){
            Console.WriteLine("Ingrese una forma de pago:");
            formadePago = char.Parse(Console.ReadLine());
            while(formadePago != 'T' && formadePago != 'E'){
                Console.WriteLine("Ingrese un método de pago válido");
                formadePago = char.Parse(Console.ReadLine());
            }
            return formadePago;
        }

        static int[] StockPorYate(int[] Stock, int posicion){

            Stock[posicion] = Stock[posicion] -1;
            return Stock;
        } 

        static int[] cantidadYatesVendidos(int[] yatesvendidos, int posicion){
            yatesvendidos[posicion] += Stock[posicion] + 1;
            return CantEntradasVendidas;
        }
    }   
}

}