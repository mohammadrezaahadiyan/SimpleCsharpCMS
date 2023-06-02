using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public int PostId { get; set; }

        public string CommentText { get; set; }

        public DateTime DateTime { get; set; }

        public virtual Post Post { get; set; }

    }
}
