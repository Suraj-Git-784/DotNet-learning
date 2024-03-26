using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AspCoreWebApi.Models;

public partial class DatabaseFirstContext : DbContext
{
    public DatabaseFirstContext()
    {
    }

    public DatabaseFirstContext(DbContextOptions<DatabaseFirstContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentTable> StudentTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StudentTable>(entity =>
        {
            entity.ToTable("StudentTable");

            entity.Property(e => e.ParentName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StudentGender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.StudentName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
