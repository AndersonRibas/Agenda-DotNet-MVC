using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AgendaDeTarefas.Models
{
    public class AgendaDeTarefasContext : DbContext
    {
        public AgendaDeTarefasContext (DbContextOptions<AgendaDeTarefasContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaDeTarefas.Models.Tarefa> Tarefa { get; set; }
    }
}
