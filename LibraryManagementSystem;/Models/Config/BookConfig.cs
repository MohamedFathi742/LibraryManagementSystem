using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem_.Models.Config;

public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {

        builder.HasKey(e => e.BookId).HasName("book_pk");

        builder.HasIndex(e => e.ISPN, "UQ__Books__447DA134B9D526ED").IsUnique();

        builder.Property(e => e.Auther)
            .IsRequired()
            .HasMaxLength(150)
            .IsUnicode(false);
        builder.Property(e => e.BookStatus)
            .IsRequired()
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("Available");
        builder.Property(e => e.CreatedAt)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime");
        builder.Property(e => e.ISPN)
            .HasMaxLength(50)
            .IsUnicode(false);
        builder.Property(e => e.Titel)
            .IsRequired()
            .HasMaxLength(200)
            .IsUnicode(false);
    }
}
