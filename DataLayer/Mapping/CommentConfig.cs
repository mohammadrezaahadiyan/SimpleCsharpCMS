using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    internal class CommentConfig:EntityTypeConfiguration<Comment>
    {
        public CommentConfig()
        {
            ToTable("Comment", "Comments");
            HasRequired(x=>x.Post).WithMany(x=>x.Comments).HasForeignKey(x=>x.PostId).WillCascadeOnDelete(false);
        }
    }
}
