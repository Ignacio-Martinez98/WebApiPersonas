using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }
        public int NroMatricula { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ciudad { get; set; }
    }
}
