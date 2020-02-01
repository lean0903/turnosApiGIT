using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Models
{
    public class Turno
    {

        public int id { get; set; }
        public JornadaServicio jornadaServicio { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
        public Usuario usuario { get; set; }
    }
}
