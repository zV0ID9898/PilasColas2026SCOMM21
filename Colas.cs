namespace Arreglos
{
    internal class Colas
    {
        private string[] _arreglo;
        private int _tope; // En la cola, _tope representa el número de elementos actuales, no el índice del último elemento

        public Colas(int elementos)
        {
            _arreglo = new string[elementos];
            _tope = 0;
        }

        public void Agregar(string elemento)
        {
            if (string.IsNullOrWhiteSpace(elemento))
            {
                throw new Exception("No se ha especificado valor a agregar.");
            }

            if (_tope == _arreglo.Length)
            {
                throw new Exception("Cola llena");
            }

            // Se agrega al final (igual que en la pila)
            _arreglo[_tope] = elemento;
            _tope++;
        }

        public void Eliminar()
        {
            if (_tope == 0)
            {
                throw new Exception("Cola vacía");
            }

            // El elemento a eliminar es el primero, que está en la posición 0
            // Desplazamos todos los elementos hacia la izquierda para llenar el espacio del elemento eliminado
            for (int i = 0; i < _tope - 1; i++)
            {
                _arreglo[i] = _arreglo[i + 1];
            }

            _tope--;
            _arreglo[_tope] = ""; // Se limpia la última posición después de desplazar los elementos 
            ///*Nota: Estuve checando otros metodos y vi que tambien se puede realizar el proceso de eliminacion usando un _inicio y un _final.
        }
        ///*NOTA: El proceso de obtener datos es exactamente igual al de las pilas, ya que el orden de los elementos en el arreglo es el mismo.
        public string ObtenerDatos()
        {
            string datos = string.Empty;

            for (int i = 0; i < _tope; i++)
            {
                datos += _arreglo[i];   // datos = datos + _arreglo[i] funciona igual
                if (i < (_tope - 1))
                {
                    datos += ",";       //mejorarlo con interpolacion de texto
                }
            }
            return datos;
        }
    }
}





