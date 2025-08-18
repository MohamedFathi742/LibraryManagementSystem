using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementSystem_.Models.Config;

public class MemberConfig:IEntityTypeConfiguration<Member>
{

   
    public void Configure(EntityTypeBuilder<Member> builder)
    {
        builder.HasKey(e => e.MemberId).HasName("members_Pk");

        builder.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
        builder.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
        builder.Property(e => e.JoinDate)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
        builder.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

    }
}
