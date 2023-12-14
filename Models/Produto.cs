using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class Produto
    {

        [Key]
        public int ProdutoId { get; set; }
        public string Nome {get;set;}
        public string Descricao {get;set;}
        public int quantidade {get;set;}
        public int preco{get;set;}
    }
}