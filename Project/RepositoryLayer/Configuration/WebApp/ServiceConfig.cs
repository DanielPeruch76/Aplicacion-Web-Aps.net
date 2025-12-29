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
    public class ServiceConfig : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.Property(x => x.CreateDate).IsRequired().HasMaxLength(10);
            builder.Property(x => x.UpdateDate).HasMaxLength(10);
            builder.Property(x => x.RowVersion).IsRowVersion();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(2000);
            builder.Property(x => x.Icon).IsRequired().HasMaxLength(100);

            builder.HasData(
                new Service
                {
                    Id=1,
                    Icon="bi bi-service1",
                    Name = "Plumbing service 1",
                    Description = "Esta es la descripción de service 1"

                },
                new Service
                {
                    Id = 2,
                    Icon = "bi bi-service2",
                    Name = "Plumbing service 2",
                    Description = "Esta es la descripción de service 2"

                },
                new Service
                {
                    Id = 3,
                    Icon = "bi bi-service3",
                    Name = "Plumbing service 3",
                    Description = "Esta es la descripción de service 3"

                }
            );
        }
    }
}
