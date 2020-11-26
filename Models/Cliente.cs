using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibreriaMvc.Models
{
    public class Cliente
    {
        [Key]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
        [Required]
        [StringLength(50)]
        [Index("IX_NombreCompleto", order: 1)]
        [Display(Name = "Nombre cliente")]
        public string Nombres { get; set; }
        [Required]
        [StringLength(50)]
        [Index("IX_NombreCompleto", order: 2)]
        public string apellido { get; set; }
        [Required]
        [StringLength(12)]
        [Index("IX_Identificacion", IsUnique = true)]
        [Display(Name = "Cedula")]
        public string Identificacion { get; set; }
        [Required]
        [StringLength(150)]
        public string Direccion { get; set; }
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
} 