using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {

        string[] Productos = {"LECHESANCOR", "COCACOLA", "QUESOPOR", "MANZARED", "PATY", "CRUSH", "ATUNCAMPA", "FRUTTIGRAM"};
        float[] Precios = {35, 100, 200, 70, 150, 45, 50, 75};
        int dni = 0;
        int numCaja = 0;
        string FormaDePago = "";
        string producto = "";
        int idProducto;
        int cantProducto = 0;
        int[] CantidadDeProductos = {0,0,0,0,0,0,0,0};
        float PrecioProducto = 0;



        Console.WriteLine("Ingresa tu dni:");
        dni = int.Parse(Console.ReadLine());

        while(dni != -1){
            
            Console.WriteLine("Ingresa el número de caja:");
            numCaja = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el producto:");
            producto = Console.ReadLine().ToUpper();

            //lectura adelantada producto
            PediryValidarProducto(producto,idProducto); //de aca tiene que volver un id y un nombre de producto válido.

            while(idProducto != -2){ //- 2 equivale a la condicoin de salida ZZZ
                    //ojo por que el producto TIENE que ser valido, sino, no pido la cantidad

                    Console.WriteLine("Ingrese la cantidad:");
                    cantProducto = int.Parse(Console.ReadLine());
            
                    //las búsquedas SIEMPRE son con while hasta que encuentro o termine de recorrer y no está.
                    for(int i = 0; i < Productos.Length; i++){

                        if(producto == Productos[i]){

                        PrecioProducto = Precios[i];
                        }
                    }   

                //lectura  producto para ciclo
                Console.WriteLine("Ingrese el producto:");
                producto = Console.ReadLine().ToUpper();

            }

        
            Console.WriteLine(dni + " compró " + cantProducto + " " + producto + " por " + PrecioProducto * cantProducto);
            Console.WriteLine("Ingrese forma de pago:");
            FormaDePago = Console.ReadLine();

            Console.WriteLine("Ingresa tu dni:");
            dni = int.Parse(Console.ReadLine());
        }
           
    }
   
  }
}
