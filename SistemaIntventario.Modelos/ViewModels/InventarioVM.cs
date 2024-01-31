using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.ViewModels
{
    public class InventarioVM
    {
        public Inventario Inventario { get; set; }
        [ValidateNever]
        public InventarioDetalle InventarioDetalle { get; set; }
        [ValidateNever]
        public IEnumerable<InventarioDetalle> InventarioDetalles { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> BodegaLista{ get; set; }

    }
}
