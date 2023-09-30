using CleanArchitectureDemo.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Common
{
    public abstract class BaseAuditableEntity : BaseEntity, IAuditableEntity 
    {
        public int? CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int? UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
