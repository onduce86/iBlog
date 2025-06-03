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
        public virtual Category Category { get; set; } = new Category();
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();     
    }
}
