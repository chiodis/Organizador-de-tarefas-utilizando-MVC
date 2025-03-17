using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizadorDeTarefas.Models
{
    public abstract class TarefaBase
    {           
        public int Id{get; set; }
        public string Titulo {get; set;}
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }

        public abstract void ExibirDetalhes();
        
    }
}