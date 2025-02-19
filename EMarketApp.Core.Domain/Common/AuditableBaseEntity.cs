﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMarketApp.Core.Domain.Common
{
    public class AuditableBaseEntity
    {
        public virtual int Id { get; set; }

        public virtual string? CreateBy { get; set; }

        public virtual DateTime Created { get; set; }

        public virtual string? LastModifiedBy { get; set; }

        public virtual DateTime? LastModified { get; set; }
    }
}
