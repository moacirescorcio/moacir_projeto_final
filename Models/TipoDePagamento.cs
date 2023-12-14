using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace projeto_final.Models
{
    public class TipoDePagamento
    {
        [Key]
        public int ProdutoId { get; set; }
        public string NomeDoCobrado {get;set;}

        public string InformacoesAdicionais {get;set;}
    }
}