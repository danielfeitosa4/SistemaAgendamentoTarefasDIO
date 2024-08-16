using Microsoft.EntityFrameworkCore;
using SistemaAgendamentoTarefasDIO.Entities;

namespace SistemaAgendamentoTarefasDIO.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
