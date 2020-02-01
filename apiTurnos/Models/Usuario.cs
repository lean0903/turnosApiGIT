using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        [Required]
        public string dni { get; set; }
        public int id {get; set; }
        public DateTime fechaNacimiento { get; set; }
        public List<Turno> turnos { get; set; }
        public List<Rol> roles { get; set; }
    }
}
