using System;
using System.Collections.Generic;
using System.Text;

namespace NetSmartz.Infrastructure.Entities.Base
{
    public class BaseEntity
    {
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? createdOn { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedOn { get; set; }

        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn  { get; set; }

    }
}
