using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDeTarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string  Titulo { get; set; }
        public string  Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public bool Status { get; set; }
    }
}
