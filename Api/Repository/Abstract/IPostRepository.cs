using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Abstract
{
  public  interface IPostRepository
    {
        List<Post> Post(int CategoryId);
        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(int Id);
    }
}
