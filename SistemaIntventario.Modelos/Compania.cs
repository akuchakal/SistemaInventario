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
    public class Compania
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nombre es requerido")]
        [MaxLength(80)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es requerido")]
        [MaxLength(200)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Pais es requerido")]
        [MaxLength(60)]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Ciudad es requerido")]
        [MaxLength(60)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "Direccion es requerido")]
        [MaxLength(200)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Telefono es requerido")]
        [MaxLength(40)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Bodega de Venta es requerido")]
        public int BodegaVentaId { get; set; }
        [ForeignKey("BodegaVentaId")]
        [ValidateNever]
        public Bodega Bodega { get; set; }

        [ValidateNever]
        public string CreadoPorId { get; set; }
        [ForeignKey("CreadoPorId")]
        [ValidateNever]
        public UsuarioAplicacion CreadoPor { get; set; }

        [ValidateNever]
        public string ActualizadoPorId { get; set; }
        [ForeignKey("ActualizadoPorId")]
        [ValidateNever]
        public UsuarioAplicacion ActualizadoPor { get; set; }

        [ValidateNever]
        public DateTime FechaCreacion { get; set; }

        [ValidateNever]
        public DateTime FechaActualizacion { get; set; }
    }
}
