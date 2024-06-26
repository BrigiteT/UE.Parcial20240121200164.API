﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UE.Parcial20240121200164.API.Data;

public partial class Parcial20240121200164Context : DbContext
{
    public Parcial20240121200164Context()
    {
    }

    public Parcial20240121200164Context(DbContextOptions<Parcial20240121200164Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Movie> Movie { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302433;Database=Parcial20240121200164;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>(entity =>
        {
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ReleaseYear)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
