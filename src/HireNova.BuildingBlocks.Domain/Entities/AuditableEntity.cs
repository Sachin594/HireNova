using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireNova.BuildingBlocks.Domain.Entities
{
    public abstract class AuditableEntity : BaseEntity
    {
        public DateTime CreatedByUtc { get; set; }
        public DateTime? ModifiedOnUtc { get; set; }
    }
}
