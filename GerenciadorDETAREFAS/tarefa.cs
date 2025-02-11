// Tarefa.cs
using System;

public class Tarefa
{
    public string Descricao { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(string descricao)
    {
        Descricao = descricao;
        Concluida = false;
    }

    public void Concluir()
    {
        Concluida = true;
    }

    // Método ToString com cores
    public override string ToString()
    {
        if (Concluida)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            return $"{Descricao} - Concluída";
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            return $"{Descricao} - Pendente";
        }
    }

    // Método para resetar a cor do texto após cada tarefa
    public static void ResetarCor()
    {
        Console.ResetColor();
    }
}
