using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;
        int count = 0;

        while (true)
        {
            Console.Write("Ingresa un puntaje (1-10) o escribe \"fin\" para terminar: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "fin")
            {
                break;
            }

            int puntaje;
            if (int.TryParse(input, out puntaje) && puntaje >= 1 && puntaje <= 10)
            {
                total += puntaje;
                count++;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Debe ser un número entre 1 y 10 o \"fin\".");
            }
        }

        if (count > 0)
        {
            double promedio = (double)total / count;
            Console.WriteLine("El puntaje promedio es: {0:F2}", promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron puntajes.");
        }
    }
}