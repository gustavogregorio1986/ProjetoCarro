﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoCarroAPI.Data.Contexto;

namespace ProjetoCarroAPI.Data.Migrations
{
    [DbContext(typeof(ProjetoCarroAPIContexto))]
    [Migration("20230612185001_dr")]
    partial class dr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoCarroAPI.Dominio.Dominio.Carro", b =>
                {
                    b.Property<int>("Idcarro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCarro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Idcarro");

                    b.ToTable("tb_Carro");
                });

            modelBuilder.Entity("ProjetoCarroAPI.Dominio.Dominio.Pagamento", b =>
                {
                    b.Property<int>("IdPagamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Pessoa")
                        .HasColumnType("int");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.Property<int>("QtdeServicos")
                        .HasColumnType("int");

                    b.HasKey("IdPagamento");

                    b.HasIndex("Id_Pessoa");

                    b.ToTable("tb_Pagamento");
                });

            modelBuilder.Entity("ProjetoCarroAPI.Dominio.Dominio.Pessoa", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailPessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Carro")
                        .HasColumnType("int");

                    b.Property<string>("NomePessoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPessoa");

                    b.HasIndex("Id_Carro");

                    b.ToTable("tb_Pessoa");
                });

            modelBuilder.Entity("ProjetoCarroAPI.Dominio.Dominio.Pagamento", b =>
                {
                    b.HasOne("ProjetoCarroAPI.Dominio.Dominio.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("Id_Pessoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoCarroAPI.Dominio.Dominio.Pessoa", b =>
                {
                    b.HasOne("ProjetoCarroAPI.Dominio.Dominio.Carro", "Carro")
                        .WithMany()
                        .HasForeignKey("Id_Carro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carro");
                });
#pragma warning restore 612, 618
        }
    }
}
