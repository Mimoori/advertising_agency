
namespace Agency.WebApp.Models
{
    public class Worker 
    {
        public int id { get; set; }
        public int id_user { get; set; }
        public enum work_role { менеджер, администратор }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
       
    }
}
