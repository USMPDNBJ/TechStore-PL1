using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mymovieapp.Models
{
    public class Producto
    {

        public int Id { get; set; }
        [Display(Name = "Nombre del producto")]
        [Required]
        public string? Nombre { get; set; }
        [Display(Name = "Descripcion del curso")]
        [Required]
        public string? Descripcion { get; set; }
        [Display(Name = "Precio del curso")]
        [Required]    
        public int? Precio { get; set; }
       
    }
}