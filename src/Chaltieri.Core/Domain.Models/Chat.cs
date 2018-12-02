using System;

namespace Chaltieri.Core.Domain.Models {
    public class Chat : IChat
    {
        public virtual Guid Id { get; set; }
        public virtual Guid FromTenantId { get; set; }
        public virtual Guid ToTenantId { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual string Message { get; set; }
    }
}