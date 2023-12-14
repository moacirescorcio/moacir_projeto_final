using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class PagamentoComCartao: TipoDePagamento
    {
    
        public string NumeroCartao {get;set;}
        public string Bandeira {get;set;}
    }
}