using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace projeto_final.Models
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }
        public string Nome {get; set;}
        public string Descricao {get; set;}
    }
}