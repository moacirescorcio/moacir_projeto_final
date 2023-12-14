using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public int Preco {get;set;}
        public int percentual {get;set;}
        public int quantidade {get;set;}
    }   
}