// GerenciadorDeTarefas.cs
using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeTarefas
{
    private List<Tarefa> tarefas;
    private const string CaminhoArquivo = "tarefas.txt";

    public GerenciadorDeTarefas()
    {
        tarefas = CarregarTarefas();
    }

    // Adicionar tarefa
    public void AdicionarTarefa(string descricao)
    {
        Tarefa novaTarefa = new Tarefa(descricao);
        tarefas.Add(novaTarefa);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Tarefa adicionada!");
        Tarefa.ResetarCor();
        SalvarTarefas();
    }

    // Listar tarefas
    public void ListarTarefas()
    {
        Console.WriteLine("\nLista de Tarefas:");
        if (tarefas.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhuma tarefa cadastrada.");
            Tarefa.ResetarCor();
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

    // Concluir tarefa
    public void ConcluirTarefa(int index)
    {
        if (index >= 0 && index < tarefas.Count)
        {
            tarefas[index].Concluir();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tarefa concluída!");
            Tarefa.ResetarCor();
            SalvarTarefas();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Índice inválido!");
            Tarefa.ResetarCor();
        }
    }

    // Remover tarefa
    public void RemoverTarefa(int index)
    {
        if (index >= 0 && index < tarefas.Count)
        {
            tarefas.RemoveAt(index);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Tarefa removida!");
            Tarefa.ResetarCor();
            SalvarTarefas();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Índice inválido!");
            Tarefa.ResetarCor();
        }
    }

    // Salvar tarefas no arquivo
    private void SalvarTarefas()
    {
        using (StreamWriter writer = new StreamWriter(CaminhoArquivo))
        {
            foreach (var tarefa in tarefas)
            {
                writer.WriteLine($"{tarefa.Descricao}|{tarefa.Concluida}");
            }
        }
    }

    // Carregar tarefas do arquivo
    private List<Tarefa> CarregarTarefas()
    {
        List<Tarefa> tarefasCarregadas = new List<Tarefa>();

        if (File.Exists(CaminhoArquivo))
        {
            var linhas = File.ReadAllLines(CaminhoArquivo);
            foreach (var linha in linhas)
            {
                var dados = linha.Split('|');
                if (dados.Length == 2)
                {
                    var descricao = dados[0];
                    var concluida = bool.Parse(dados[1]);
                    Tarefa tarefa = new Tarefa(descricao) { Concluida = concluida };
                    tarefasCarregadas.Add(tarefa);
                }
            }
        }

        return tarefasCarregadas;
    }
}
