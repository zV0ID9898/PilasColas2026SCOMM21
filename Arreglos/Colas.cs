namespace Arreglos
{
    internal class Colas
    {
        private string[] _arreglo;
        private int _inicio;
        private int _fin;
        private int _cantidad;
        //en el apartado de colas se utiliza el concepto de circularidad, es decir, cuando se llega al final del arreglo, se vuelve al inicio para aprovechar el espacio disponible.

        public Colas(int elementos) //a continuacion se define el constructor de la clase colas, el cual recibe como parametro la cantidad de elementos que llevara la cola, se estableceran las variables inicio, fin y cantidad en 0.
        {
            _arreglo = new string[elementos];
            _inicio = 0;
            _fin = 0;
            _cantidad = 0;
        }

        public void Agregar(string elemento) // a continuacion se define el metodo de agregar elementos a la cola, el cual se verifica si el elemento a agregar es nulo o esta vacio, si es asi lanza una excepcion, luego se verifica si la cantidad de elementos en la cola es igual a la longitud del arreglo, si es asi lanza una
                                             // excepcion de cola llena, si no se agrega el elemento al arreglo en la posicion del fin, luego se avanza circularmente el fin y se incrementa la cantidad de elementos en la cola.
        {
            if (string.IsNullOrWhiteSpace(elemento))
            {
                throw new Exception("No se ha especificado valor a agregar.");
            }

            if (_cantidad == _arreglo.Length)
            {
                throw new Exception("Cola llena");
            }

            _arreglo[_fin] = elemento;

            // Avanza circularmente
            _fin = (_fin + 1) % _arreglo.Length;
            _cantidad++;
        }

        public void Eliminar() // a continuacion se define el metodo de eliminar elementos de la cola, el cual se verifica si la cantidad de elementos en la cola es igual a 0, si es asi lanza una excepcion de cola vacia, si no se elimina el elemento del arreglo en la posicion del inicio,
                               // luego se avanza circularmente el inicio y se decrementa la cantidad de elementos en la cola.
{
            if (_cantidad == 0)
            {
                throw new Exception("Cola vacía");
            }

            _arreglo[_inicio] = ""; // opcional limpiar

            // Avanza circularmente
            _inicio = (_inicio + 1) % _arreglo.Length;
            _cantidad--;
        }

        public string ObtenerDatos() // a continuacion se define el metodo de obtener los datos de la cola, el cual se recorre el arreglo desde el inicio hasta la cantidad de elementos en la cola,
                                     // se obtiene el indice circularmente y se concatenan los elementos en una cadena separada por comas.
        {
            string datos = string.Empty;

            for (int i = 0; i < _cantidad; i++)
            {
                int indice = (_inicio + i) % _arreglo.Length;
                datos += _arreglo[indice];

                if (i < _cantidad - 1)
                {
                    datos += ",";
                }
            }

            return datos;
        }
    }
}


