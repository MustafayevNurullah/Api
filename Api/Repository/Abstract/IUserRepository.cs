using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Abstract
{
  public  interface IUserRepository
    {
        List<User> Users(int CommentId);
        User GetUser(string Email);

        void AddUser(User user);

    }
}
