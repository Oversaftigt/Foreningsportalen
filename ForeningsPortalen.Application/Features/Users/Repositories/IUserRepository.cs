using ForeningsPortalen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Application.Features.Users.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(User booking, byte[] rowVersion);
        User GetUser(Guid id);
        void UpdateUser(User user, byte[] rowVersion);

    }
}
