using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repoInsight.Models;

public class Usuario{
    public int Id {get; set;}

    [MaxLength(100)]
    public string Nome {get; set;}

    [MaxLength(100)]
    public string Email {get; set;}

    [MaxLength(100)]
    public string Senha {get; set;}

    public DateTime DataCriacao {get; set;}

    public DateTime UltimoAcesso {get; set;}

    public Usuario()
    {
        DataCriacao = DateTime.Now;
        UltimoAcesso = DateTime.Now;
    }

}