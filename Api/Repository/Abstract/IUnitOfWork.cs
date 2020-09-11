using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repository.Abstract
{
    interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Category { get; }
        ICommentRepository Comment { get; }
        IPostRepository Post { get; }
        IUserRepository User { get; }
    }
}
