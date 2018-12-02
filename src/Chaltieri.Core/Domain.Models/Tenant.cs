using System;

namespace Chaltieri.Core.Domain.Models {
    public class Tenant : ITenant {
        public virtual Guid Id { get; set; }
        public virtual string Username { get; set; }
    }
}