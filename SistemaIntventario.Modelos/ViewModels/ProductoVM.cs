using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.ViewModels
{
    public class ProductoVM
    {
        public Producto Producto { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> CategoriaLista { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> MarcaLista { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> PadreLista { get; set; }
    }
}
