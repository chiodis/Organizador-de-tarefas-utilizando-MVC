using OrganizadorDeTarefas.Views;

namespace OrganizadorDeTarefas
{
    class Program
    {
        static void Main()
        {
            var view = new TarefaView();
            view.ExibirMenu();
        }
    }
}