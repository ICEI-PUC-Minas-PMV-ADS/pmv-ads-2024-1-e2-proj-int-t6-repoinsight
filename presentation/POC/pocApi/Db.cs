using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Banco{
    public class RepoDb: DbContext{
        public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Repo> Repos {get; set;}
        public DbSet<ConfigBusca> configBuscas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=BancoPoc;user=SA;password=<YourStrong@Passw0rd>;TrustServerCertificate=true;");
        }

    }

    public class Usuario{
        public int Id {get; set;}

        [MaxLength(100)]
        public string Nome {get; set;}

        [MaxLength(100)]
        public string Email {get; set;}

        [MaxLength(100)]
        public string GithubId {get; set;}

        [MaxLength(100)]
        public string Senha {get; set;}
        public DateTime DataCriacao {get; set;}
        public DateTime UltimoAcesso {get; set;}

    }

    public class Repo{
        public int Id {get; set;}

        [MaxLength(100)]
        public string Nome {get; set;}
        public bool Favorito {get; set;}
        public bool watch {get; set;}
        public int QtdContribuintes {get; set;}
        public int QtdBranches {get; set;}
        public int QtdCommits {get; set;}
        public int QtdPrs {get; set;}
        public DateTime DataCriacao {get; set;}
        public DateTime DataAlteracao {get; set;}
        public DateTime DataVisita {get; set;}

        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public int IdUsuario {get; set;}
    }

    public class ConfigBusca{
        public int Id {get; set;}

        [MaxLength(100)]
        public string TpFiltro {get; set;}

        [MaxLength(100)]
        public string TpMudanca {get; set;}

        [ForeignKey("Usuario")]
        [Column(Order = 1)]
        public int IdUsuario {get; set;}
    }
}