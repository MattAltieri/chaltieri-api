using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chaltieri.Core.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Chaltieri.Api.Controllers
{
    // [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        
        [HttpGet]
        public async Task<IEnumerable<IChat>> Chats() {

            return await Task.FromResult(new List<IChat> {
                new Chat {
                    Id = Guid.NewGuid(),
                    FromTenantId = Guid.NewGuid(),
                    ToTenantId = Guid.NewGuid(),
                    Timestamp = DateTime.Now,
                    Message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                },
                new Chat {
                    Id = Guid.NewGuid(),
                    FromTenantId = Guid.NewGuid(),
                    ToTenantId = Guid.NewGuid(),
                    Timestamp = DateTime.Now,
                    Message = "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",
                },
                new Chat {
                    Id = Guid.NewGuid(),
                    FromTenantId = Guid.NewGuid(),
                    ToTenantId = Guid.NewGuid(),
                    Timestamp = DateTime.Now,
                    Message = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                },
                new Chat {
                    Id = Guid.NewGuid(),
                    FromTenantId = Guid.NewGuid(),
                    ToTenantId = Guid.NewGuid(),
                    Timestamp = DateTime.Now,
                    Message = "xcepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                }
            });
        }
    }
}
