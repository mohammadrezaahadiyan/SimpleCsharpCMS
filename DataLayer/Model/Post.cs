using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        public int CategoryId { get; set; }

        public string PostTitle { get; set; }

        public string PostDescription { get; set; }

        public int Visit { get; set; }

        public DateTime CreateDate { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } 

    }
}
