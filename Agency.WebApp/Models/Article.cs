namespace Agency.WebApp.Models
{
    public class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string descriptions { get; set; }
        public DateOnly datetime { get; set; }
    }
}
