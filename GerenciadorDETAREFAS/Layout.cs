// Layout.cs
using System;

public static class Layout
{
    // Método para exibir o cabeçalho
    public static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n========================");
        Console.WriteLine("  Gerenciador de Tarefas");
        Console.WriteLine("========================");
        Tarefa.ResetarCor();
    }

    // Método para exibir o menu de opções
    public static void ExibirMenu()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1. Adicionar tarefa");
        Console.WriteLine("2. Listar tarefas");
        Console.WriteLine("3. Concluir tarefa");
        Console.WriteLine("4. Remover tarefa");
        Console.WriteLine("5. Sair");
        Console.Write("Opção: ");
    }

    // Método para exibir uma mensagem de sucesso
    public static void ExibirMensagemSucesso(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mensagem);
        Tarefa.ResetarCor();
    }

    // Método para exibir uma mensagem de erro
    public static void ExibirMensagemErro(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(mensagem);
        Tarefa.ResetarCor();
    }

    // Método para exibir uma lista de tarefas
    public static void ExibirTarefas(List<Tarefa> tarefas)
    {
        Console.WriteLine("\nLista de Tarefas:");
        if (tarefas.Count == 0)
        {
            ExibirMensagemErro("Nenhuma tarefa cadastrada.");
        }
        else
        {
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i]}");
            }
        }
        Tarefa.ResetarCor();
    }
}
