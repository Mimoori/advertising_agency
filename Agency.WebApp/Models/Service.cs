namespace Agency.WebApp.Models
{
    public class Service
    {
        public int id { get; set; }
        public string name_service { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public DateOnly period_of_execution { get; set; }
    }
}
