using System;
using OrganizadorDeTarefas.Controllers;
using OrganizadorDeTarefas.Models;

namespace OrganizadorDeTarefas.Views
{
    public class TarefaView
    {
        private readonly TarefaController _controller;

        public TarefaView()
        {
            _controller = new TarefaController();
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Criar Tarefa");
                Console.WriteLine("2. Listar Tarefas");
                Console.WriteLine("3. Atualizar Tarefa");
                Console.WriteLine("4. Deletar Tarefa");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");
                var opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CriarTarefa();
                        break;
                    case "2":
                        ListarTarefas();
                        break;
                    case "3":
                        AtualizarTarefa();
                        break;
                    case "4":
                        DeletarTarefa();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        private void CriarTarefa()
        {
            Console.Write("Título: ");
            var titulo = Console.ReadLine();
            Console.Write("Descrição: ");
            var descricao = Console.ReadLine();
            Console.Write("Data (yyyy-MM-dd): ");
            var data = DateTime.Parse(Console.ReadLine());
            Console.Write("Status (0 para Pendente, 1 para Finalizado): ");
            var status = (EnumStatusTarefa)int.Parse(Console.ReadLine());

            _controller.CriarTarefa(titulo, descricao, data, status);
        }

        private void ListarTarefas()
        {
            _controller.ListarTarefas();
        }

        private void AtualizarTarefa()
        {
            Console.Write("ID da Tarefa: ");
            var id = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            var titulo = Console.ReadLine();
            Console.Write("Descrição: ");
            var descricao = Console.ReadLine();
            Console.Write("Data (yyyy-MM-dd): ");
            var data = DateTime.Parse(Console.ReadLine());
            Console.Write("Status (0 para Pendente, 1 para Finalizado): ");
            var status = (EnumStatusTarefa)int.Parse(Console.ReadLine());

            _controller.AtualizarTarefa(id, titulo, descricao, data, status);
        }

        private void DeletarTarefa()
        {
            Console.Write("ID da Tarefa: ");
            var id = int.Parse(Console.ReadLine());
            _controller.DeletarTarefa(id);
        }
    }
}