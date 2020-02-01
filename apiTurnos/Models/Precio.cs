using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Models
{
    public class Precio
    {
        [Key]
        public DateTime fechahora { get; set; }
        public float importe { get; set; }
        public Servicio servicioId { get; set; }
    }
}
