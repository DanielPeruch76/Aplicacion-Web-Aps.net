using EntityLayer.WebApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryLayer.Configuration.WebApp
{
    public class TestimonialConfig : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdateDate).HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.Comment).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.FileType).IsRequired();

            builder.HasData(
                new Testimonial
                {
                    Id = 1,
                    Comment = "Este es el comentario del testimonio",
                    Title = "Interesting",
                    FullName = "Merlyn Monroe",
                    FileName = "test",
                    FileType = "test",
                },
                new Testimonial
                {
                    Id = 2,
                    Comment = "Este es el comentario del testimonio",
                    Title = "Interesting",
                    FullName = "Jackie Chan",
                    FileName = "test",
                    FileType = "test",
                },
                new Testimonial
                {
                    Id = 3,
                    Comment = "Este es el comentario del testimonio",
                    Title = "Interesting",
                    FullName = "Bruce Wills",
                    FileName = "test",
                    FileType = "test",
                }
            );
        }
    }
}
