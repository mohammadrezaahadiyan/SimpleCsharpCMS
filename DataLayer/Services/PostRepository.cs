using DataLayer.Context;
using DataLayer.Model;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class PostRepository : IPostRepository
    {
        ProjectContext db = new ProjectContext();
        public IEnumerable<Post> GetAll()
        {
            var list = db.Posts.ToList();
            return list;
        }


        public Post GetById(int postId)
        {
            var GetId = db.Posts.Find(postId);
            return GetId;
        }


        public bool Create(Post post)
        {
            try
            {
                var AddToPost = db.Posts.Add(post);
                return true;
            }

            catch
            {
                throw new Exception("عملیات ناموق بود");
            }
        }

        public bool Edit(Post post)
        {
            try
            {
                db.Entry(post).State = EntityState.Modified;
                return true;
            }

            catch
            {
                throw new Exception("ویرایش ناموفق بود");
            }
        }


        public bool DeleteById(int postId)
        {
            try
            {
                var getId = GetById(postId);
                db.Posts.Remove(getId);
                return true;
            }

            catch
            {
                throw new Exception("عملیات حذف با خطا مواجه شد");
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
