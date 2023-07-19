using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataBase
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Nombre { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, ingresa un e-mail valido.")]
        public string? Email { get; set; }

        public DateTime? FechaCreacion { get; set; }
    }
}
