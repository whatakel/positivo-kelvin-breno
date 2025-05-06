using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int somaPares = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] % 2 == 0)
            {
                somaPares += numeros[i];
            }
        }

        Console.WriteLine("A soma dos números pares é: " + somaPares);
    }
}
