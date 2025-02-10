using System;

namespace Layout
{
    public static class Formatacao
    {
        // Método para exibir mensagem com cor
        public static void Cor(string mensagem, ConsoleColor cor)
        {
            if (string.IsNullOrEmpty(mensagem))
            {
                Console.WriteLine("Mensagem vazia ou nula.");
                return;
            }
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        // Método para exibir mensagem com cor de fundo e texto
        public static void CorFundo(string mensagem, ConsoleColor corTexto, ConsoleColor corFundo)
        {
            if (string.IsNullOrEmpty(mensagem))
            {
                Console.WriteLine("Mensagem vazia ou nula.");
                return;
            }

            Console.BackgroundColor = corFundo;
            Console.ForegroundColor = corTexto;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        // Método para exibir uma linha com cor personalizada
        public static void Linha(ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(new string('-', Console.WindowWidth - 1));
            Console.ResetColor();
        }

        // Método para exibir a mensagem com "negrito" (simulação)
        public static void Negrito(string mensagem)
        {
            Cor(mensagem.ToUpper(), ConsoleColor.White); // Simula o negrito com maiúsculas
        }
    }
}
