using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Numero de serie requerido")]
        [MaxLength(60)]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "Descripcion requerido")]
        [MaxLength(60)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Precio requerido")]
        public Double Precio { get; set; }

        [Required(ErrorMessage = "Costo requerido")]
        public Double Costo { get; set; }

        public string? ImagenUrl { get; set; }

        [Required(ErrorMessage = "Estado requerido")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "Categoria requerido")]
        public int CategoriaId { get; set; }
        [ValidateNever]
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Marca requerido")]
        public int MarcaId { get; set; }
        [ValidateNever]
        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        public int? PadreId { get; set; }
        [ValidateNever]
        public virtual Producto Padre { get; set; }
    }
}
