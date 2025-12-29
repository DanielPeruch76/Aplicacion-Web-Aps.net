using EntityLayer.WebApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Configuration.WebApp
{
    public class PortafolioConfig : IEntityTypeConfiguration<Portafolio>
    {
        public void Configure(EntityTypeBuilder<Portafolio> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdateDate).HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(200);
            builder.Property(x => x.FileName).IsRequired();
            builder.Property(x => x.FileType).IsRequired();

            builder.HasData(
                new Portafolio
                {
                    Id = 1,
                    CategoryId = 1,
                    FileName = "Test",
                    FileType = "test",
                    Title = "Test Picture",
                },
                new Portafolio
                {
                    Id = 2,
                    CategoryId = 1,
                    FileName = "Test2",
                    FileType = "test2",
                    Title = "Test Picture2",
                },
                new Portafolio
                {
                    Id = 3,
                    CategoryId = 2,
                    FileName = "Test3",
                    FileType = "test3",
                    Title = "Test Picture3",
                },
                new Portafolio
                {
                    Id = 4,
                    CategoryId = 2,
                    FileName = "Test4",
                    FileType = "test4",
                    Title = "Test Picture4",
                }
            );
        }
    }
}
