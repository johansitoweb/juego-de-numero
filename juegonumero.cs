using System;

class AdivinaElNumero
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int intento;
        Console.WriteLine("Adivina un número entre 1 y 100:");

        do
        {
            intento = int.Parse(Console.ReadLine());
            if (intento < numeroSecreto) Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
            else if (intento > numeroSecreto) Console.WriteLine("Demasiado alto. Intenta de nuevo.");
        } while (intento != numeroSecreto);

        Console.WriteLine("¡Correcto! Has adivinado el número.");
    }
}
