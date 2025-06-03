using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iBlog.EntityLayer.Concrete
{
    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }

        public string PostImage { get; set; }

        public DateTime PostDate { get; set; } = DateTime.Now;

        public bool PostStatus { get; set; } = true;


        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = new Category(); // Navigation property to Category 


        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>(); // Navigation property to Comments    


        public virtual ICollection<Tag> Tags { get; set; } = new List<Tag>(); // Navigation property to Tags    


        public virtual ICollection<PostTag> PostTags { get; set; } = new List<PostTag>(); // Navigation property to PostTags    


        public Post()
        {
            // Initialize collections to avoid null reference exceptions
            Comments = new List<Comment>();
            Tags = new List<Tag>();
            PostTags = new List<PostTag>();
        }




    }
}
