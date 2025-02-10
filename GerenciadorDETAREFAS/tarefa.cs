namespace GerenciamentoDeTarefas
{
    public class Tarefa
    {
        public string Descricao { get; set; }  // Descrição da tarefa
        public bool Concluida { get; set; }    // Status de conclusão da tarefa

        // Construtor da classe Tarefa
        public Tarefa(string descricao)
        {
            Descricao = descricao;
            Concluida = false; // A tarefa começa como não concluída
        }

        // Método para exibir as informações da tarefa
        public void Exibir()
        {
            Console.WriteLine($"{Descricao} - {(Concluida ? "Concluída" : "Pendente")}");
        }

        // Método para marcar a tarefa como concluída
        public void MarcarComoConcluida()
        {
            Concluida = true;
            Console.WriteLine("Tarefa marcada como concluída.");
        }

        // Método para editar a descrição da tarefa
        public void EditarDescricao(string novaDescricao)
        {
            Descricao = novaDescricao;
            Console.WriteLine("Descrição da tarefa alterada com sucesso.");
        }
    }
}
