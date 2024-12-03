using Fornecedores.Models;
using Microsoft.EntityFrameworkCore;


namespace Fornecedores.Data // namespace = pasta de trabalho //
{
    public class AppCont : DbContext // classe que avisa ao Banco de Dados
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {
            // metodo CONSTRUTOR que evidencia que tudo o que precisa esta dentro dessa classe - APPCONT//
        }
        public DbSet<Fornecedor> Tarefas { get; set; } // evidencia a tabela Tarefas //
        public object Fornecedor { get; internal set; }
    }
}
