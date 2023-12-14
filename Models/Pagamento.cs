using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace projeto_final.Models
{
    public class Pagamento
    {
        [Key]
        public int PagamentoId { get; set; }
        public DateTime DataLimite {get;set;}
        public double Valor {get;set;}
        public bool Pago{get;set;}
    }
}