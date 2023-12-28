namespace CrudApps.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public bool IsActive{ get; set; }
        public bool IsDeleted { get; set; }
    }
}
