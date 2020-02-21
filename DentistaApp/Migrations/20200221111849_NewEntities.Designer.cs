﻿// <auto-generated />
using System;
using DentistaApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DentistaApp.Migrations
{
    [DbContext(typeof(DentistaAppContext))]
    [Migration("20200221111849_NewEntities")]
    partial class NewEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DentistaApp.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cidade");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("DentistaApp.Models.Dentista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Usuario");

                    b.HasKey("Id");

                    b.ToTable("Dentista");
                });

            modelBuilder.Entity("DentistaApp.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Cadastro");

                    b.Property<string>("Nome");

                    b.Property<int>("TipoProduto");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("DentistaApp.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<int>("Estoque");

                    b.Property<int?>("FornecedorId");

                    b.Property<string>("Nome");

                    b.Property<int>("Tipo");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("DentistaApp.Models.Produto", b =>
                {
                    b.HasOne("DentistaApp.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId");
                });
#pragma warning restore 612, 618
        }
    }
}