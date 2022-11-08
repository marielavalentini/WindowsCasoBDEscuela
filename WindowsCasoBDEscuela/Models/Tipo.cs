using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCasoBDEscuela.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de Navegacion 
        public List<Evaluacion> Evaluaciones { get; set; }
        #endregion
    }
}
