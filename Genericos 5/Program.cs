using System;

namespace Genericos_5
{
    /*Ejecricio 5 
    - Crear un arreglo  de int. double y string
    - Crear un metodo generico que reciba un arreglo y una posición
    - y retome un string indicando el valor del elemento y el tipo del mismo.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int [] intArray = {1,2,3,4};
            double[] doubleArray = {1.1,2.2,3.3,4.4};
            string[] stringArray = {"pepe", "silvia"};
            
            Console.WriteLine(InformarValorTipo(intArray, 0));
            Console.WriteLine(InformarValorTipo(intArray, 3));
            Console.WriteLine(InformarValorTipo(intArray, 2));
        }

         static void InformarValorTipo<T>(T[] inputArray, int posicion)
        {
            var elemento = inputArray[posicion];
            return $"{elemento} es de tipo {elemento.GetType()}";
        }
    }
}
