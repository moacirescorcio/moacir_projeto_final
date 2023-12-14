using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace projeto_final.Models
{
    public class PagamentoComCheque: TipoDePagamento
    {
    
        public int Banco {get;set;}
        public string NomeDoBanco {get;set;}
    }
}