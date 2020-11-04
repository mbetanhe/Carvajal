using Carvajal.CORE.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carvajal.CORE.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task Delete(User user);
        IEnumerable<User> GetAll();
        Task<User> GetUserByID(int id);
        Task Update(User user);
    }
}