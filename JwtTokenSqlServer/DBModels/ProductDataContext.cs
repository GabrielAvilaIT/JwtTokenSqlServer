using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace JwtTokenSqlServer.DBModels;

public class ProductDataContext : DbContext
{ 
    public ProductDataContext()
    {
    }

    public ProductDataContext(DbContextOptions<ProductDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClientTokens> ClientTokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-RM5Q6V26;Initial Catalog=JwtTokenSQL;uid=TestTokenJwt;password=TokenJwt;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<ClientTokens>(entity =>
        {
            entity.HasKey(e => e.ClientId);

            entity.ToTable("ClientTokens");

            entity.Property(e => e.ClientId).HasMaxLength(50);
            entity.Property(e => e.Secret).HasMaxLength(50);
        });

        //OnModelCreatingPartial(modelBuilder);
    }
    

    //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

