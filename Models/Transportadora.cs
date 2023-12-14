using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace projeto_final.Models
{
    public class Transportadora
    {
        [Key]
        public int TransportadoraId { get; set; }
        public string Nome {get;set;}
    }
}