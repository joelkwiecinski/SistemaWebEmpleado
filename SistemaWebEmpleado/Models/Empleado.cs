﻿using SistemaWebEmpleado.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    {

        [DisplayName("ID")]
        [Key]
        public int EmpleadoId { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string DNI { get; set; }

        [Required]
        [CheckLegajo]
        public string Legajo { get; set; }

        [Required]
        [DisplayName("Título")]
        public string Titulo { get; set; }

    }
}
