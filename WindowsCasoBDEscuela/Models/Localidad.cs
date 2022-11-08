﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsCasoBDEscuela.Models
{
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de Navegacion 
        public List<Estudiante> Estudiantes { get; set; }
        public List<Profesor> Profesores { get; set; }
        #endregion
    }
}
