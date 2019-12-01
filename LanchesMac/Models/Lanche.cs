using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required]
        [Display(Name = "Informe o nome")]
        [StringLength(80, MinimumLength = 10)]
        public string Nome { get; set; }

        [Required]
        [MinLength(20)]
        [MaxLength(200)]
        public string DescricaoCurta { get; set; }

        [Required]
        [MinLength(20)]
        [MaxLength(200)]
        public string DescricaoDetalhada { get; set; }

        public decimal Preco { get; set; }

        [StringLength(200)]
        public string ImagemUrl { get; set; }

        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }

        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
