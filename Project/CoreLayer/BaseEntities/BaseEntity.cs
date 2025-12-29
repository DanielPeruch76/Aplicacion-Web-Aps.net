using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.BaseEntities
{
    public class BaseEntity<PK> : IBaseEntity<PK>
    {
        public virtual PK Id { get; set; }
        public virtual string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public virtual string? UpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; } = null!;
    }
}
