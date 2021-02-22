using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Turnos.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get ; set; }
        [StringLength(50, ErrorMessage = "El campo descripción debe tener como máximo 50 caracteres")]
        [Required (ErrorMessage = "Debe ingresar una descripción")]
        [Display (Name = "Descripción")]
        public string Descripcion { get; set; }
        public List<MedicoEspecialidad> MedicoEspecialidad { get; set; }
    }
}