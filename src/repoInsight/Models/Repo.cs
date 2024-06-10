using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repoInsight.Models;

public class Repo{
    public int Id {get; set;}

    [MaxLength(100)]
    public string Nome {get; set;}
    [MaxLength(300)]
    public string? Descricao {get; set;}

    public DateTime DataCriacao {get; set;}

    public DateTime DataVisita {get; set;}

    [ForeignKey("Usuario")]
    [Column(Order = 1)]
    public int IdUsuario {get; set;}

    public Repo()
    {
        DataCriacao = DateTime.Now;
        DataVisita = DateTime.Now;
    }
}