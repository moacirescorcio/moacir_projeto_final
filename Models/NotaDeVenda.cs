using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace projeto_final.Models
{
    public class NotaDeVenda
    {

        [Key]
        public int NotaId { get; set; }
        public DateTime Data { get; set; }
        public bool Tipo { get; set; }

        public bool Cancelar(){
            return true;
        }

        public bool Devolber(){
            return true;
        }
    }
}