using Project.DAL.Repository.Concretes;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repository.Abstracts
{
    public interface IAppUserRepository : IRepository<AppUser>
    {
        Task<bool> AddUser(AppUser user);
    }
}
