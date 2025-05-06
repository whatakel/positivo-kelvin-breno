﻿using System;

class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotal()
    {
        return Preco * Quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[3];

        for (int i = 0; i < 3; i++)
        {
            produtos[i] = new Produto();
            Console.WriteLine($"Produto {i + 1}:");
            Console.Write("Nome: ");
            produtos[i].Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produtos[i].Preco = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade: ");
            produtos[i].Quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        Console.WriteLine("Produtos cadastrados:\n");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Nome: {produtos[i].Nome}");
            Console.WriteLine($"Preço: {produtos[i].Preco}");
            Console.WriteLine($"Quantidade: {produtos[i].Quantidade}");
            Console.WriteLine($"Valor em estoque: {produtos[i].ValorTotal()}");
            Console.WriteLine();
        }
    }
}
