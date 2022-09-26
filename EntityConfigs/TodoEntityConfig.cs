using Microsoft.EntityFrameworkCore;
using TWTodoList.Models;

namespace TWTodoList.EntiyConfigs;  

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TWTodoList.Models;
public class TodoEntityConfig : IEntityTypeConfiguration<Todo>
{
    public void Configure(EntityTypeBuilder<Todo> builder)
    {
        builder.ToTable("todo");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
                .HasColumnName("id");
        
        builder.Property(x => x.Title)
                .HasColumnName("title")
                .HasColumnType("nvarchar(100)")
                .IsRequired();

        builder.Property(x => x.Date)
               .HasColumnName("date")
               .HasColumnType("date")
               .IsRequired();
        
        builder.Property(x => x.isCompleted)
                .HasColumnName("is_completed")
                .HasColumnType("bit")
                .IsRequired();
    }
}
