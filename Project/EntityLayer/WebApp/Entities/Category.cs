using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApp.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = null!;
        List<Portafolio> Portafolios { get; set; } = null!;
    }
}
