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
    public class CategoryRepository : ICategoryRepository
    {
        ProjectContext db = new ProjectContext();
        public IEnumerable<Category> GetAll()
        {
            var list = db.Categories.ToList();
            return list;
        }

        public Category GetById(int categoryId)
        {
            var GetId = db.Categories.Find(categoryId);
            return GetId;
        }
        public bool Create(Category category)
        {
            try
            {
                var AddToCategory = db.Categories.Add(category);
                return true;
            }

            catch
            {
                throw new Exception("عملیات ناموفق");
            }
        }

        public bool Edit(Category category)
        {
            try
            {
                db.Entry(category).State = EntityState.Modified;
                return true;
            }

            catch
            {
                throw new Exception("ویرایش ناموفق بود");
            }
        }

        public bool DeleteById(int categoryId)
        {
            try
            {
                var GetId = GetById(categoryId);
                db.Categories.Remove(GetId);
                return true;
            }


            catch
            {
                throw new Exception("عملیات خذف با خطا مواجه شد");
            }

        }

        public void Saave()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

    }
}
    
