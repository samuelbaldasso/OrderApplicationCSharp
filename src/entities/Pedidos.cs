
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("pedidos")]
public class Pedidos
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Produto { get; set; } = string.Empty;

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Valor { get; set; }

    [Required]
    public int Quantidade { get; set; }

    [Required]
    [MaxLength(50)]
    public string Status { get; set; } = string.Empty;


}
