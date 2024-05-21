using System.ComponentModel.DataAnnotations;

namespace repoInsight.Models;

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