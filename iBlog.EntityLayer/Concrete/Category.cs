namespace iBlog.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string CategoryDescription { get; set; } = string.Empty;
        public string CategoryImage { get; set; } = string.Empty;
        public bool CategoryStatus { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
