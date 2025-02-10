using System;
using System.Collections.Generic;
using Layout;      // Usando a classe Layout para formatação
using GerenciamentoDeTarefas;  // Usando a classe GerenciarTarefas para manipulação das tarefas

class Program
{
    static void Main(string[] args)
    {
        // Inicializa o sistema de gerenciamento de tarefas
        GerenciarTarefas gerenciador = new GerenciarTarefas(); // Corrigido: inicializando corretamente

        while (true)
        {
            // Exibe o menu interativo
            Console.Clear();
            Console.WriteLine("Sistema de Gerenciamento de Tarefas");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Marcar Tarefa como Concluída");
            Console.WriteLine("4 - Editar Tarefa");
            Console.WriteLine("5 - Excluir Tarefa");
            Console.WriteLine("6 - Exibir Mensagem Colorida");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            
         Console.Write("Escolha uma opção: ");
string opcao = Console.ReadLine();  // Usando ReadLine para capturar a opção do usuário


            // Tratamento de entrada inválida para o menu
            if (!int.TryParse(opcao, out int escolha) || escolha < 0 || escolha > 6)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (escolha)
            {
                case 1:
                    // Adicionar tarefa
                    gerenciador.AdicionarTarefa();
                    break;

                case 2:
                    // Listar tarefas
                    gerenciador.ListarTarefas();
                    break;

                case 3:
                    // Marcar tarefa como concluída
                    gerenciador.MarcarTarefaConcluida();
                    break;

                case 4:
                    // Editar tarefa
                    gerenciador.EditarTarefa();
                    break;

                case 5:
                    // Excluir tarefa
                    gerenciador.ExcluirTarefa();
                    break;

                case 6:
                    // Exibir mensagem colorida
                    gerenciador.ExibirMensagemColorida();
                    break;

                case 0:
                    // Sair
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            // Pausa a execução até que o usuário pressione uma tecla
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
