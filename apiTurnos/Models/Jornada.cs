using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Models
{
    public class Jornada
    {
        public DateTime apertura { get; set; }
        public DateTime cierre { get; set; }
        public int id { get; set; }
        public Empresa empresa { get; set; }
        public JornadaServicio diaServicio { get; set; }
    }
}
