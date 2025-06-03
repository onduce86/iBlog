namespace iBlog.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; } = string.Empty;
        public DateTime CommentDate { get; set; } = DateTime.Now;
        public bool CommentStatus { get; set; } = true;

        public int PostId { get; set; }
        public virtual Post Post { get; set; } = new Post();
    }
}
