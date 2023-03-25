using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        bool esPrimo = true;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                esPrimo = false;
                break;
            }
        }

        if (esPrimo)
        {
            Console.WriteLine("{0} es un número primo.", n);
        }
        else
        {
            Console.WriteLine("{0} no es un número primo.", n);
        }
    }
}