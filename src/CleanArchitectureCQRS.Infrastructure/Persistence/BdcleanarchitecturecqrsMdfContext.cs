using System;
using System.Collections.Generic;
using CleanArchitectureCQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitectureCQRS.Infrastructure;

public partial class BdcleanarchitecturecqrsMdfContext : DbContext
{
    public BdcleanarchitecturecqrsMdfContext()
    {
        this.ChangeTracker.LazyLoadingEnabled = false;
        

    }

    public BdcleanarchitecturecqrsMdfContext(DbContextOptions<BdcleanarchitecturecqrsMdfContext> options)
        : base(options)
    {
        
    }


    public virtual DbSet<Cidade> Cidades { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteContato> ClienteContatos { get; set; }

    public virtual DbSet<ClienteDocumento> ClienteDocumentos { get; set; }

    public virtual DbSet<ClienteEndereco> ClienteEnderecos { get; set; }


    public virtual DbSet<Estado> Estados { get; set; }

    


    public virtual DbSet<Pai> Pais { get; set; }



    public virtual DbSet<TipoContato> TipoContatos { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Cidade>(entity =>
        {
            entity.ToTable("Cidade");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_Cidade_Ativo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_Cidade_CreatedAt");
            entity.Property(e => e.Descricao).HasMaxLength(160);
            entity.Property(e => e.Tenantid).HasColumnName("tenantid");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);

            entity.HasOne(d => d.Estado).WithMany(p => p.Cidades)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cidade_Estado");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_Cliente_Ativo");
            entity.Property(e => e.ConsentimentoDados).HasDefaultValue(true, "DF_Cliente_ConsentDados");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_Cliente_CreatedAt");
            entity.Property(e => e.Nome).HasMaxLength(160);
            entity.Property(e => e.Observacao).HasMaxLength(500);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);


        });

        modelBuilder.Entity<ClienteContato>(entity =>
        {
            entity.ToTable("ClienteContato");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_ClienteContato_Ativo");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_ClienteContato_CreatedAt");
            entity.Property(e => e.Descricao).HasMaxLength(200);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);

            entity.HasOne(d => d.Cliente).WithMany(p => p.ClienteContatos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteContato_Cliente");


            entity.HasOne(d => d.TipoContato).WithMany(p => p.ClienteContatos)
                .HasForeignKey(d => d.TipoContatoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteContato_TipoContato");
        });

        modelBuilder.Entity<ClienteDocumento>(entity =>
        {
            entity.ToTable("ClienteDocumento");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_ClienteDocumento_Ativo");
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_ClienteDocumento_CreatedAt");
            entity.Property(e => e.Numero).HasMaxLength(60);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);

            entity.HasOne(d => d.Cliente).WithMany(p => p.ClienteDocumentos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteDocumento_Cliente");


            entity.HasOne(d => d.TipoDocumento).WithMany(p => p.ClienteDocumentos)
                .HasForeignKey(d => d.TipoDocumentoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteDocumento_TipoDocumento");
        });

        modelBuilder.Entity<ClienteEndereco>(entity =>
        {
            entity.ToTable("ClienteEndereco");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_ClienteEndereco_Ativo");
            entity.Property(e => e.Bairro).HasMaxLength(120);
            entity.Property(e => e.Cep).HasMaxLength(15);
            entity.Property(e => e.Complemento).HasMaxLength(120);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_ClienteEndereco_CreatedAt");
            entity.Property(e => e.Logradouro).HasMaxLength(200);
            entity.Property(e => e.Numero).HasMaxLength(30);
            entity.Property(e => e.UpdatedAt).HasPrecision(3);

            entity.HasOne(d => d.Cidade).WithMany(p => p.ClienteEnderecos)
                .HasForeignKey(d => d.CidadeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteEndereco_Cidade");

            entity.HasOne(d => d.Cliente).WithMany(p => p.ClienteEnderecos)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteEndereco_Cliente");


        });



        modelBuilder.Entity<Estado>(entity =>
        {
            entity.ToTable("Estado");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_Estado_Ativo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_Estado_CreatedAt");
            entity.Property(e => e.Descricao).HasMaxLength(120);
            entity.Property(e => e.Tenantid).HasColumnName("tenantid");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);

            entity.HasOne(d => d.Pais).WithMany(p => p.Estados)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Estado_Pais");
        });





        modelBuilder.Entity<Pai>(entity =>
        {
            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_Pais_Ativo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_Pais_CreatedAt");
            entity.Property(e => e.Descricao).HasMaxLength(120);
            entity.Property(e => e.Tenantid).HasColumnName("tenantid");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });





        modelBuilder.Entity<TipoContato>(entity =>
        {
            entity.ToTable("TipoContato");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_TipoContato_Ativo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_TipoContato_CreatedAt");
            entity.Property(e => e.Descricao).HasMaxLength(120);
            entity.Property(e => e.Tenantid).HasColumnName("tenantid");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.ToTable("TipoDocumento");

            entity.Property(e => e.Ativo).HasDefaultValue(true, "DF_TipoDocumento_Ativo");
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreatedAt)
                .HasPrecision(3)
                .HasDefaultValueSql("(sysdatetime())", "DF_TipoDocumento_CreatedAt");
            entity.Property(e => e.Descricao).HasMaxLength(120);
            entity.Property(e => e.Tenantid).HasColumnName("tenantid");
            entity.Property(e => e.UpdatedAt).HasPrecision(3);
        });

  

   



    }

    
}
