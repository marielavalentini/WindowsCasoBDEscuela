﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCasoBDEscuela.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de Navegacion

        public List<Planilla> Planillas { get; set; }
        #endregion
    }
}
