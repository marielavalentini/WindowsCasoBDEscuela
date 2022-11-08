﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCasoBDEscuela.Models
{
    [Table("Estado")]
    public class Estado
    {
        public int EstadoId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de Navegacion 
        public List<Detalle> Detalles { get; set; }
        #endregion
    }
}
