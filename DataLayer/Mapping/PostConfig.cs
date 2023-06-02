using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Mapping
{
    public class PostConfig:EntityTypeConfiguration<Post>
    {
        public PostConfig()
        {

            ToTable("Post", "Posts");
            HasRequired(x=>x.Category).WithMany(x=>x.Posts).HasForeignKey(x=>x.CategoryId).WillCascadeOnDelete(false);
            
        }
    }
}
