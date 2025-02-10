using System;
using System.Collections.Generic;
using GerenciamentoDeTarefas; // Para usar a classe Tarefa
using Layout; // Para usar a classe Formatacao

namespace GerenciamentoDeTarefas
{
    public class GerenciarTarefas
    {
        // Lista para armazenar as tarefas
        private List<Tarefa> tarefas = new List<Tarefa>();

        // Método para adicionar uma nova tarefa
        public void AdicionarTarefa()
        {
            Console.Write("Digite a descrição da tarefa: ");
            string descricao = Console.ReadLine();
            if (string.IsNullOrEmpty(descricao))
            {
                Console.WriteLine("A descrição da tarefa não pode ser vazia.");
                return;
            }

            Tarefa novaTarefa = new Tarefa(descricao);
            tarefas.Add(novaTarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
        }

        // Método para listar todas as tarefas
        public void ListarTarefas()
        {
            if (tarefas.Count == 0)
            {
                Console.WriteLine("Não há tarefas cadastradas.");
                return;
            }

            Console.WriteLine("\nLista de Tarefas:");
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tarefas[i].Descricao} - {(tarefas[i].Concluida ? "Concluída" : "Pendente")}");
            }
        }

        // Método para marcar uma tarefa como concluída
        public void MarcarTarefaConcluida()
        {
            Console.Write("Digite o número da tarefa para marcar como concluída: ");
            if (int.TryParse(Console.ReadLine(), out int indiceConcluida) && indiceConcluida > 0 && indiceConcluida <= tarefas.Count)
            {
                tarefas[indiceConcluida - 1].MarcarComoConcluida();
            }
            else
            {
                Console.WriteLine("Índice inválido. Tente novamente.");
            }
        }

        // Método para editar a descrição de uma tarefa
        public void EditarTarefa()
        {
            Console.Write("Digite o número da tarefa para editar: ");
            if (int.TryParse(Console.ReadLine(), out int indiceEditar) && indiceEditar > 0 && indiceEditar <= tarefas.Count)
            {
                Console.Write("Digite a nova descrição da tarefa: ");
                string novaDescricao = Console.ReadLine();
                tarefas[indiceEditar - 1].EditarDescricao(novaDescricao);
            }
            else
            {
                Console.WriteLine("Índice inválido. Tente novamente.");
            }
        }

        // Método para excluir uma tarefa
        public void ExcluirTarefa()
        {
            Console.Write("Digite o número da tarefa para excluir: ");
            if (int.TryParse(Console.ReadLine(), out int indiceExcluir) && indiceExcluir > 0 && indiceExcluir <= tarefas.Count)
            {
                tarefas.RemoveAt(indiceExcluir - 1);
                Console.WriteLine("Tarefa excluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Índice inválido. Tente novamente.");
            }
        }

        // Método para exibir mensagem colorida
        public void ExibirMensagemColorida()
        {
            Console.Write("Digite a mensagem: ");
            string mensagem = Console.ReadLine();
            Console.Write("Escolha a cor (Red, Green, Blue, Yellow, etc): ");
            string corEscolhida = Console.ReadLine();
            if (Enum.TryParse(corEscolhida, true, out ConsoleColor cor))
            {
                Console.ForegroundColor = cor;
                Console.WriteLine(mensagem);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Cor inválida. Tente novamente.");
            }
        }
    }
}
