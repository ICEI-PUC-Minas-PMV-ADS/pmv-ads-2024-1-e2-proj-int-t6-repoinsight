using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repoInsight.Models;

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