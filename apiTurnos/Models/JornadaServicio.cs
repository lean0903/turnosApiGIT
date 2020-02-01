using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Models
{
    public class JornadaServicio
    {
        public int jornadaId { get; set; }
        public int servicioId { get; set; }
        public  Jornada jornada { get; set; }
        public Servicio servicio { get; set; }
        public List<Turno>turnos { get; set; }
    }
}
