using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InvitacionEventos.Models
{
    public class Invitaciones
    {
        [Required(ErrorMessage = "Debe introducir su nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe introducir su correo")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "El formato de email no es valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe introducir su telefono")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Por favor debe especificar la asistencia")]
        public bool? Asistira { get; set; }
    }
}