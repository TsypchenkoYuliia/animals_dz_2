using DataAccess.Context;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repository.Interfaces
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(AnimalContext context) : base(context) { }
    }
}
