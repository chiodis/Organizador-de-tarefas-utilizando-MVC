using System;
using System.Linq;
using OrganizadorDeTarefas.Models;

namespace OrganizadorDeTarefas.Controllers
{
    public class TarefaController
    {
        private readonly OrganizadorContext _context;

        public TarefaController()
        {
            _context = new OrganizadorContext();
            _context.Database.EnsureCreated();
        }

        public void CriarTarefa(string titulo, string descricao, DateTime data, EnumStatusTarefa status)
        {
            var tarefa = new TarefaSimples { Titulo = titulo, Descricao = descricao, Data = data, Status = status };
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }

        public void ListarTarefas()
        {
            var tarefas = _context.Tarefas.ToList();
            foreach (var tarefa in tarefas)
            {
                tarefa.ExibirDetalhes();
            }
        }

        public void AtualizarTarefa(int id, string titulo, string descricao, DateTime data, EnumStatusTarefa status)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa != null)
            {
                tarefa.Titulo = titulo;
                tarefa.Descricao = descricao;
                tarefa.Data = data;
                tarefa.Status = status;
                _context.SaveChanges();
            }
        }

        public void DeletarTarefa(int id)
        {
            var tarefa = _context.Tarefas.Find(id);
            if (tarefa != null)
            {
                _context.Tarefas.Remove(tarefa);
                _context.SaveChanges();
            }
        }
    }
}