using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizadorDeTarefas.Models
{
        public class TarefaSimples : TarefaBase
        {
        public override void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {Id}, Titulo: {Titulo}, Descrição: {Descricao}, Data: {Data}, Status: {Status}");
        }
    }
    }
