 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaMvc.Models
{
    public class Autor
    {
        [Key]
        [Display(Name = "Autor De Libro")]
        public int AutorId{ get; set; }
        [Required]
        [StringLength(50)]
        [Index("IX_NombreCompleto", order: 1)]
        [Display(Name = "Nombre Autor")]
        public string Nombres { get; set; }
        [Required]
        [StringLength(50)]
        [Index("IX_NombreCompleto", order: 2)]
        public string apellido { get; set; }
        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(50)]
        public string Tematica { get; set; }
    }
} 