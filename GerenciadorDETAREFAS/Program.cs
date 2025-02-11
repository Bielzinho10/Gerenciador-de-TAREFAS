// Program.cs
using System;

class Program
{
    static void Main()
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();

        while (true)
        {
            Layout.ExibirCabecalho();
            Layout.ExibirMenu();
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    gerenciador.AdicionarTarefa(descricao);
                    break;

                case "2":
                    gerenciador.ListarTarefas();
                    break;

                case "3":
                    Console.Write("Digite o número da tarefa a ser concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int indexConcluir))
                    {
                        gerenciador.ConcluirTarefa(indexConcluir - 1); // Subtrai 1 porque o usuário verá a tarefa começando do número 1.
                    }
                    else
                    {
                        Layout.ExibirMensagemErro("Entrada inválida!");
                    }
                    break;

                case "4":
                    Console.Write("Digite o número da tarefa a ser removida: ");
                    if (int.TryParse(Console.ReadLine(), out int indexRemover))
                    {
                        gerenciador.RemoverTarefa(indexRemover - 1); // Subtrai 1 porque o usuário verá a tarefa começando do número 1.
                    }
                    else
                    {
                        Layout.ExibirMensagemErro("Entrada inválida!");
                    }
                    break;

                case "5":
                    Layout.ExibirMensagemSucesso("Saindo do programa...");
                    System.Threading.Thread.Sleep(1000); // 1 segundo para o usuário ler a mensagem
                    return;

                default:
                    Layout.ExibirMensagemErro("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}
