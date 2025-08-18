using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem_.Models.Config;

public class BorrowingConfig : IEntityTypeConfiguration<Borrowing>
{
    public void Configure(EntityTypeBuilder<Borrowing> builder)
    {
        builder.HasKey(e => e.BorrowId).HasName("PK__Borrowin__4295F83F3047E7D9");

        builder.Property(e => e.BorrowDate).HasColumnType("datetime");
        builder.Property(e => e.BorrowStatus)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false);
        builder.Property(e => e.ReturnDate).HasColumnType("datetime");

        builder.HasOne(d => d.Book).WithMany(p => p.Borrowings)
            .HasForeignKey(d => d.BookId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Borrowings_Books_fk");

        builder.HasOne(d => d.Member).WithMany(p => p.Borrowings)
            .HasForeignKey(d => d.MemberId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Borrowings_Members_fk");
    }
}
