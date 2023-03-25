using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero positivo: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Los números pares del 1 al {0} son:", n);
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}