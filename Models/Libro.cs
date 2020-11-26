using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LibreriaMvc.Models
{
    public class Libro
    {
        [Key]

        public int libroId { get; set; }
        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }
        [Required]
        [StringLength(50)]
        public string Tipolibro { get; set; }
        [Required]
        [StringLength(50)]
        public string Editorial{ get; set; }

        //propiedad de clave for
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }


        //propiedad de navegacio
        
        public virtual Cliente Cliente { get; set; }
        //propiedad de clave for

        [Display(Name = "Autor De Libro")]
        public int  AutorId { get; set; }


        //propiedad de navegacio

        public virtual Autor Autor { get; set; }
    }
}