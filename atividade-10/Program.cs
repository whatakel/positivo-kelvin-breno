using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>();
        List<bool> concluidas = new List<bool>();
        string opcao = "";

        while (opcao != "4")
        {
            Console.WriteLine("1 - Adicionar tarefa");
            Console.WriteLine("2 - Marcar tarefa como concluída");
            Console.WriteLine("3 - Listar tarefas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.Write("Digite a tarefa: ");
                string tarefa = Console.ReadLine();
                tarefas.Add(tarefa);
                concluidas.Add(false);
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Tarefas:");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    string status = concluidas[i] ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                }
                Console.Write("Digite o número da tarefa que deseja marcar como concluída: ");
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= tarefas.Count)
                {
                    concluidas[num - 1] = true;
                }
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Lista de Tarefas:");
                for (int i = 0; i < tarefas.Count; i++)
                {
                    string status = concluidas[i] ? "[X]" : "[ ]";
                    Console.WriteLine($"{i + 1}. {status} {tarefas[i]}");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("Programa encerrado.");
    }
}
