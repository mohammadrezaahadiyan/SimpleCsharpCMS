using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Category
    {

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}
