using Microsoft.EntityFrameworkCore;
using projeto_final.Models;

namespace democsharp.Models
{
   public class MyDbContext : DbContext
   {
       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
       {
       }

       public DbSet<Item> Item {get; set;}
       public DbSet<Marca> Marca {get; set;}
       public DbSet<NotaDeVenda> NotaDeVenda {get; set;}
       public DbSet<Pagamento> Pagamento {get; set;}
       public DbSet<PagamentoComCartao> PagamentoComCartoe {get; set;}
       public DbSet<PagamentoComCheque> PagamentoComChque {get; set;}
       public DbSet<Produto> Produto {get; set;}
       public DbSet<TipoDePagamento> TipoDePagamento {get; set;}
       public DbSet<Transportadora> Transportadora {get; set;}
       public DbSet<Vendedor> Vendedor {get; set;}
   }
}
