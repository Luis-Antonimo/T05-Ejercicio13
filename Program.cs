using System;

namespace T05Ejercicio13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¿Qué longitud (entero positivo) quiere para el array?: ");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[longitud];
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int aleatorio = rnd.Next(1, 11);//El valor máximo de rnd.Next no entra en el rango                
                array[i] = aleatorio;
                Console.WriteLine("Del array de tamaño "+ longitud + " el valor del "+ (i+1) + "º valor es: " + array[i]);
            }
        }
    }
}