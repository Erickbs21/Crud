using System.ComponentModel.DataAnnotations;

namespace AppFuturista.Models
{
    public class Usuario
    {
        public string Id { get; set; }
        
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [Display(Name = "Nombre de Usuario")]
        public string NombreUsuario { get; set; }
        
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        [Display(Name = "Contraseña")]
        public string Contraseña { get; set; }
        
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto { get; set; }
        
        [Display(Name = "Rol")]
        public string Rol { get; set; } = "Usuario";
    }
}
