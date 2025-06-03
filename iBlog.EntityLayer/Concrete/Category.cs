namespace iBlog.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string CategoryImage { get; set; }
        public bool CategoryStatus { get; set; }


        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();            




    }
}
