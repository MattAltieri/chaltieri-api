using System;

namespace Chaltieri.Core.Domain.Models {
    public interface ITenant {
         Guid Id { get; set; }
         string Username { get; set; }
    }
}