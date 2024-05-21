using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using repoInsight.Models;

namespace repoInsight.Data
{
    public class RepoInsightContext : DbContext
    {
        public RepoInsightContext (DbContextOptions<RepoInsightContext> options)
            : base(options)
        {
        }

        public DbSet<repoInsight.Models.Usuario> Usuario { get; set; }
        public DbSet<repoInsight.Models.Repo> Repo { get; set; }
        public DbSet<repoInsight.Models.ConfigBusca> ConfigBusca { get; set; }        
    }
}