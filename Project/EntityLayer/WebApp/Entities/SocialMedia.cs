using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApp.Entities
{
    public class SocialMedia : BaseEntity
    {
        public string? Twitter { get; set; }
        public string? Linkedin { get; set; }
        public string? FaceBook { get; set; }
        public string? Instagram { get; set; }

        public AboutUs AboutUs { get; set; } = null!;
    }
}
