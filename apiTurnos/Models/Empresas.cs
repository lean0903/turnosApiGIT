using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace apiTurnos.Models
{
    public class Empresas
    {
        
        public int id { get; set; }
        public  string Razon_social { get; set; }
        [Column (TypeName ="nvarchar(60)")]
        public string Direccion { get; set; }


    }
}
