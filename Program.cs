namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--------probando con pilas--------------------------");
                Pilas pila = new Pilas(5);

                pila.Agregar("A");
                pila.Agregar("B");
                pila.Agregar("C");

                Console.WriteLine(pila.ObtenerDatos());

                pila.Agregar("D");
                Console.WriteLine("Agregando D");
                Console.WriteLine(pila.ObtenerDatos());
                Console.WriteLine("Eliminando D");
                pila.Eliminar();
                Console.WriteLine(pila.ObtenerDatos());
                Console.WriteLine("Eliminando C");
                pila.Eliminar();

                //Agregando problemas
                //pila.Agregar("");
                pila.Eliminar();
                pila.Eliminar();
                pila.Eliminar();
                Console.WriteLine(pila.ObtenerDatos());



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                try
                {
                    //En este caso el proceso para agregar es el mismo a las pilas no cambia en absolutamente nada
                    Console.WriteLine("--------probando con colas--------------------------");
                    Colas cola = new Colas(5);
                    cola.Agregar("A");
                    cola.Agregar("B");
                    cola.Agregar("C");

                    Console.WriteLine(cola.ObtenerDatos());
                    cola.Agregar("D");
                    Console.WriteLine("Agregando D");
                    Console.WriteLine(cola.ObtenerDatos());
                    //en este caso empezamos escribiendo en consola el proceso de eliminación, para que se vea claramente el orden de eliminación
                    Console.WriteLine("Eliminando A");
                    cola.Eliminar();
                    Console.WriteLine(cola.ObtenerDatos());
                    Console.WriteLine("Eliminando B");
                    cola.Eliminar();
                    Console.WriteLine(cola.ObtenerDatos());
                    Console.WriteLine("Eliminando C");
                    cola.Eliminar();
                    Console.WriteLine(cola.ObtenerDatos());
                    cola.Eliminar();
                    cola.Eliminar();    
                    Console.WriteLine(cola.ObtenerDatos());
                }
              
                catch (Exception ex2)
                {
                    Console.WriteLine(ex2.Message);

                }
            }
        }
    }

}















