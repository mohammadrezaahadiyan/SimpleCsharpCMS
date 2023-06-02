using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IPostRepository:IDisposable
    {

        IEnumerable<Post> GetAll();

        Post GetById(int postId);

        bool Create(Post post);

        bool Edit(Post post);

        bool DeleteById(int postId);

        void Save();

    }
}
