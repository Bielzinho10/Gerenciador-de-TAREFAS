using System;
using System.Collections.Generic;

namespace GerenciarTarefa
{
    public class Gerenciar
    {
        private static List<Tarefas.Tarefa> tarefas = new List<Tarefas.Tarefa>();
        private static int contadorId = 1;

        // Método para adicionar uma tarefa
        public static void AdicionarTarefa(string descricao)
        {
            var tarefa = new Tarefas.Tarefa(contadorId++, descricao);
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        // Método para concluir uma tarefa
        public static void ConcluirTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Console.WriteLine("Tarefa concluída!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }

        // Método para listar as tarefas
        public static void ListarTarefas()
        {
            Console.WriteLine("Tarefas:");
            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirTarefa();
            }
        }

        // Método para remover uma tarefa
        public static void RemoverTarefa(int id)
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefas.Remove(tarefa);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada!");
            }
        }
    }
}
