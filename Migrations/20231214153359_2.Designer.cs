﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using democsharp.Models;

#nullable disable

namespace projeto_final.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231214153359_2")]
    partial class _2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("projeto_final.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Preco")
                        .HasColumnType("int");

                    b.Property<int>("percentual")
                        .HasColumnType("int");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("ItemId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("projeto_final.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("projeto_final.Models.NotaDeVenda", b =>
                {
                    b.Property<int>("NotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Tipo")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("NotaId");

                    b.ToTable("NotaDeVenda");
                });

            modelBuilder.Entity("projeto_final.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLimite")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Pago")
                        .HasColumnType("tinyint(1)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("PagamentoId");

                    b.ToTable("Pagamento");
                });

            modelBuilder.Entity("projeto_final.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("preco")
                        .HasColumnType("int");

                    b.Property<int>("quantidade")
                        .HasColumnType("int");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("projeto_final.Models.TipoDePagamento", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InformacoesAdicionais")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDoCobrado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProdutoId");

                    b.ToTable("TipoDePagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("TipoDePagamento");
                });

            modelBuilder.Entity("projeto_final.Models.Transportadora", b =>
                {
                    b.Property<int>("TransportadoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TransportadoraId");

                    b.ToTable("Transportadora");
                });

            modelBuilder.Entity("projeto_final.Models.Vendedor", b =>
                {
                    b.Property<int>("VendedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("VendedorId");

                    b.ToTable("Vendedor");
                });

            modelBuilder.Entity("projeto_final.Models.PagamentoComCartao", b =>
                {
                    b.HasBaseType("projeto_final.Models.TipoDePagamento");

                    b.Property<string>("Bandeira")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NumeroCartao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCartao");
                });

            modelBuilder.Entity("projeto_final.Models.PagamentoComCheque", b =>
                {
                    b.HasBaseType("projeto_final.Models.TipoDePagamento");

                    b.Property<int>("Banco")
                        .HasColumnType("int");

                    b.Property<string>("NomeDoBanco")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("PagamentoComCheque");
                });
#pragma warning restore 612, 618
        }
    }
}
