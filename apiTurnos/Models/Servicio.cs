using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Models
{
    public class Servicio
    {
        public int id { get; set; }
        public string name { get; set; }
        public string descripcion { get; set; }
        public List<Precio> Precios { get; set; }
        public Empresa empresa { get; set; }
    }
}
