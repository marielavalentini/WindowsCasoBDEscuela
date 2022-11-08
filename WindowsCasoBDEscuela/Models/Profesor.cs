using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCasoBDEscuela.Models
{
    [Table("Profesor")]
    public class Profesor
    {
        [Key]
        public int ProfesorId { get; set; }
        [Required]
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        #region Propiedades de Navegacion 
        [ForeignKey("LocalidadId")]
        
        public Localidad Localidad { get; set; }
        public List<Planilla> Planillas { get; set; }
        #endregion
    }
}
