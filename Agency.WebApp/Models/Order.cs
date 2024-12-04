namespace Agency.WebApp.Models
{
    public class Order
    {
        public int id { get; set; }
        public int id_client { get; set; }
        public string discription { get; set; }
        public string service_name { get; set; }
        public DateOnly date_start { get; set; }
        public DateOnly date_end { get; set; }
    }
}
