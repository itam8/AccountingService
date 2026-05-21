using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountingService
{
    public class RequestConfiguration : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.ToTable("requests");

            builder.HasKey(r => r.Id)
                    .HasName("requests_pkey");

            builder.Property(r => r.Id)
                .HasColumnName("id");

            builder.Property(r => r.UserId)
                .HasColumnName("user_id");

            builder.Property(r => r.ReferenceType)
                .HasColumnName("reference_type")
                .IsRequired();

            builder.Property(r => r.CopiesCount)
                .HasColumnName("copies_count")
                .IsRequired();

            builder.Property(r => r.Reason)
                .HasColumnName("reason")
                .IsRequired();

            builder.Property(r => r.Status)
                .HasColumnName("status")
                .IsRequired();

            builder.Property(r => r.Date)
                .HasColumnName("date")
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .IsRequired();

            builder.HasOne(r => r.User)
                .WithMany(u => u.Requests)
                .HasForeignKey(r => r.UserId)
                .HasConstraintName("requests_user_id_fkey");
        }
    }
}
