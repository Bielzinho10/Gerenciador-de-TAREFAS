using System;
using Layout;
using GerenciarTarefa;

namespace SistemaDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                // Exibir cabeçalho
                Formatação.ImprimirCabecalho();
                
                // Menu de opções
                Console.WriteLine("1. Adicionar Tarefa");
                Console.WriteLine("2. Concluir Tarefa");
                Console.WriteLine("3. Listar Tarefas");
                Console.WriteLine("4. Remover Tarefa");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        // Adicionar Tarefa
                        Console.Write("Digite a descrição da tarefa: ");
                        string descricao = Console.ReadLine();
                        GerenciarTarefa.Gerenciar.AdicionarTarefa(descricao);
                        break;

                    case "2":
                        // Concluir Tarefa
                        Console.Write("Digite o ID da tarefa a concluir: ");
                        if (int.TryParse(Console.ReadLine(), out int idConcluir))
                        {
                            GerenciarTarefa.Gerenciar.ConcluirTarefa(idConcluir);
                        }
                        else
                        {
                            Console.WriteLine("ID inválido.");
                        }
                        break;

                    case "3":
                        // Listar Tarefas
                        GerenciarTarefa.Gerenciar.ListarTarefas();
                        break;

                    case "4":
                        // Remover Tarefa
                        Console.Write("Digite o ID da tarefa a remover: ");
                        if (int.TryParse(Console.ReadLine(), out int idRemover))
                        {
                            GerenciarTarefa.Gerenciar.RemoverTarefa(idRemover);
                        }
                        else
                        {
                            Console.WriteLine("ID inválido.");
                        }
                        break;

                    case "5":
                        // Sair
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}
