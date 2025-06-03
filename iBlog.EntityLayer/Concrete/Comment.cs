namespace iBlog.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; } = DateTime.Now; // Default to current date and time   

        public bool CommentStatus { get; set; } = true; // Default to true (active) 

        public int PostId { get; set; } // Foreign key to Post  

    }
}
