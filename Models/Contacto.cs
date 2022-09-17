using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppContactos.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre es obligatorios")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Telefono es obligatorios")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El Celular es obligatorios")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "El Email es obligatorios")]
        public string Email { get; set; }



    }
}