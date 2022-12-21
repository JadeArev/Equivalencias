using System;

namespace HelloWorld
{
  class Program
  {
     static void Main(string[] args)
    {
      string[] Productos = {"LECHESANCOR", "COCACOLA", "QUESOPOR", "MANZARED", "PATY", "CRUSH", "ATUNCAMPA", "FRUTIGRAN"};
      int [] Precios = {35, 100, 200, 70, 150, 45, 50, 75};
      int dni = 0;
      int numCaja = 0;
      string producto = "";
      int cantidad = 0;
      char formadePago = '\0';
      int posicion = 0; 
      int totalProducto = 0;
      int ticket= 0;
      int total = 0;
      int descontado = 0; 
      const int cajas = 10;
      int[] clientesXCaja = new int[cajas] {0,0,0,0,0,0,0,0,0,0};
      int[] ProductosMasVendidos = new int[8] {0,0,0,0,0,0,0,0};
      int max = 0;
      string productomasvendido = "";
      int contadorclientes = 0;
      int min = clientesXCaja[0];
      int cajamenosclientes = 0;
      Console.WriteLine("Ingrese tu DNI");
      dni = int.Parse(Console.ReadLine());

        while(dni != -1){

        ticket = 0;
        descontado = 0;
        contadorclientes = 0;
        
        numCaja = PedirCaja(numCaja);
          Console.WriteLine("Ingrese el producto:");
          producto = Console.ReadLine().ToUpper();

            while(producto != "ZZZ" && producto != "zzz"){
            posicion = BusquedaYValidaProducto(Productos, producto);
                if(posicion==-1){
                  Console.WriteLine("Error. Ingresar un tipo de entrada válido.");
                  posicion = BusquedaYValidaProducto(Productos, producto);
                  }
                  else{
                    cantidad = PedirCantidad(cantidad);
                    totalProducto = Precios[posicion] * cantidad;
                     ticket += totalProducto;
                  }
                Console.WriteLine("Ingrese el producto:");
                producto = Console.ReadLine().ToUpper();
                ProductosMasVendidos = ProdsMasVendidos(posicion, cantidad, ProductosMasVendidos);
                  for(int i = 0; i < ProductosMasVendidos.Length; i++){
                    if(ProductosMasVendidos[i] > max){
                    max = ProductosMasVendidos[i];
                    productomasvendido = Productos[i];
            }
        }
    }    
                formadePago = PedirPago(formadePago);
                 if(formadePago == 'E'){
                    descontado = (ticket * 5) / 100;
                    Console.WriteLine(dni + " abona " + (ticket - descontado) + " con " + formadePago);
                    }
                 else{
                    Console.WriteLine(dni + " abona " + ticket + " con " + formadePago);
                 }

                total += ticket - descontado;
                clientesXCaja = ClientesPorCaja(clientesXCaja, numCaja, contadorclientes);
                
                Console.WriteLine("Ingrese su DNI");
                dni = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("la recaudación total es " + total);
            
            for(int i = 0; i < ProductosMasVendidos.Length; i++){
                Console.WriteLine("El producto " + Productos[i] + " se vendió " + ProductosMasVendidos[i] + " veces.");
            }
        Console.WriteLine("El producto más vendida es " + productomasvendido + " cuya cantidad es " + max);
            for(int i = 0; i < clientesXCaja.Length; i++){
                Console.WriteLine("En la caja " + (i+1) + " hubieron " + clientesXCaja[i] + " clientes.");
            }

            cajamenosclientes = MenosClientes(clientesXCaja, numCaja, min, cajamenosclientes);
            Console.WriteLine("la caja con menos clientes es " + cajamenosclientes);
        }
        static int PedirCaja(int numCaja){

            Console.WriteLine("Ingresar número de caja");
            numCaja = int.Parse(Console.ReadLine());
                while(numCaja < 1 || numCaja > 10){
                Console.WriteLine("Error. Ingrese un número de caja válido.");
                numCaja = int.Parse(Console.ReadLine());
            }
            return numCaja;
        }

        static int BusquedaYValidaProducto(string[] Productos, string producto){
             int posicion = -1;
             int idProducto = 0;
             bool aparecio = false;

                while(idProducto < Productos.Length && !aparecio){

                    if(producto == Productos[idProducto]){

                    posicion = idProducto;
                    aparecio = true;
                    }
                        idProducto++;
                }
                return posicion;
        }      
        static int PedirCantidad(int cantidad){
            Console.WriteLine("Ingrese la cantidad de productos:");
            cantidad = int.Parse(Console.ReadLine());
            while(cantidad < 1){
                Console.WriteLine("Error. Ingrese una cantidad válida.");
                cantidad = int.Parse(Console.ReadLine());
            }
            return cantidad;
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

        static int[] ProdsMasVendidos(int posicion, int cantidad, int[] ProductosMasVendidos){

            ProductosMasVendidos[posicion] += cantidad;
            return ProductosMasVendidos;
        }

        static int[] ClientesPorCaja(int[] clientesXCaja, int numCaja, int contadorclientes){

            contadorclientes = 1;
            clientesXCaja[numCaja-1] += contadorclientes;
            return clientesXCaja;
        }

        static int MenosClientes(int[] clientesXCaja, int numCaja, int min, int cajamenosclientes){

            for(int i = 0; i < clientesXCaja.Length; i++){
                if(clientesXCaja[i] < min){
                    min = clientesXCaja[i];
                    cajamenosclientes = numCaja;
                }
            }
            return cajamenosclientes;
        }
    }      
  }
