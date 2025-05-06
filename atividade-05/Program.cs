using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma palavra ou frase:");
        string texto = Console.ReadLine().ToLower();
        texto = texto.Replace(" ", "");

        char[] textoArray = texto.ToCharArray();
        Array.Reverse(textoArray);
        string textoInvertido = new string(textoArray);

        if (texto == textoInvertido)
        {
            Console.WriteLine("É um palíndromo!");
        }
        else
        {
            Console.WriteLine("Não é um palíndromo.");
        }
    }
}
