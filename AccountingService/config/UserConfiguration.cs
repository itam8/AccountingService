using AccountingService.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingService.config
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");

            builder.HasKey(u => u.Id)
                .HasName("users_pkey");

            builder.HasIndex(u => u.Login, "users_login_key")
                .IsUnique();

            builder.Property(u => u.Id)
                .HasColumnName("id");

            builder.Property(u => u.Login)
                .HasColumnName("login")
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnName("password")
                .IsRequired();

            builder.Property(u => u.Firstname)
                .HasColumnName("firstname")
                .IsRequired();

            builder.Property(u => u.Lastname)
                .HasColumnName("lastname")
                .IsRequired();

            builder.Property(u => u.Middlename)
                .HasColumnName("middlename")
                .IsRequired();

            builder.Property(u => u.Role)
                .HasColumnName("role")
                .IsRequired();
        }
    }
}
