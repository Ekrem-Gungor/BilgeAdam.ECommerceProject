using Project.DAL.ContextClasses;
using Project.DAL.Repository.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repository.Concretes
{
    public class ProfileRepository : BaseRepository<AppUserProfile>, IProfileRepository
    {
        public ProfileRepository(MyContext db) : base(db)
        {

        }
    }
}
