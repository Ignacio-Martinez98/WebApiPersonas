using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SWMedicos.Models
{
    [Table("Medico")]
    public class Medico
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
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Especialidad { get; set; }     
        public int NroMatricula { get; set; }

        [Column(TypeName = "date")]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yy}")]  //Para probar que no imprima la hora(por ahora no funciona)
        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Ciudad { get; set; }

    }
}
