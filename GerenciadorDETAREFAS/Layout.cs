using System;

namespace Layout
{
    public class Formatação
    {
        // Método para imprimir mensagens coloridas
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        // Método para imprimir o cabeçalho
        public static void ImprimirCabecalho()
        {
            Console.Clear();
            Cor("=== Sistema de Gestão de Tarefas ===", ConsoleColor.Green);
            Console.WriteLine("=====================================");
        }
    }
}
