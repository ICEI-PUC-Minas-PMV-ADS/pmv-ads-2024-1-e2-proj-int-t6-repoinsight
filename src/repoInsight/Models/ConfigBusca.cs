using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace repoInsight.Models;

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