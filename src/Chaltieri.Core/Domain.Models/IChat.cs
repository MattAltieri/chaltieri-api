using System;

namespace Chaltieri.Core.Domain.Models {
    public interface IChat {
         Guid Id { get; set; }
         Guid FromTenantId { get; set; }
         Guid ToTenantId { get; set; }
         DateTime Timestamp { get; set; }
         string Message { get; set; }
    }
}