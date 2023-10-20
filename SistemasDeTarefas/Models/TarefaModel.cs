using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        public string? Descricao {get; set;}
        public int Status {get; set;}
    }
}