using Agency.WebApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Agency.WebApp.Models

{
    public enum Status
    {
        [Display(Name = "Рассматриваемое менеджером")] Considered = 0,
        [Display(Name = "Отправлено в работу")] Active = 1,
        [Display(Name = "Завершено")] End = 2,
        [Display(Name = "Отменено")] Fall = 3
    }
    public class Order
    {
        public int id { get; set; }
        public string id_client { get; set; }
        public string discription { get; set; }
        public int service { get; set; }
        public Status status { get; set; }
        public DateOnly date_start { get; set; }
        public DateOnly date_end { get; set; }
    }

}
