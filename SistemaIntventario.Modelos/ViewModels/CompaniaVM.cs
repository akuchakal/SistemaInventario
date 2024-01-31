using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.ViewModels
{
    public class CompaniaVM
    {
        public Compania Compania { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> BodegaLista { get; set; }
    }
}
