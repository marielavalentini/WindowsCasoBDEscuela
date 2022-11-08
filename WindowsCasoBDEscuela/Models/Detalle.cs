using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCasoBDEscuela.Models
{
    [Table("Detalle")]
    public class Detalle
    {
        public int DetalleId { get; set; }
        public int PlanillaId { get; set; }
        public int EstadoId { get; set; }

        #region Propiedades de Navegacion 
        
        public Estado Estado { get; set; }
        public Planilla Planilla { get; set; }
        public List<Evaluacion> Evaluacion { get; set; }
        #endregion
    }
}
