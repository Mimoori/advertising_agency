using Agency.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Database.EntityModels
{
    public class Article
    {
        private Article(string title, string description, DateOnly datetime) 
        { 
            this.title = title; 
            this.descriptions = description; 
            this.datetime = datetime; 
        }

        public const int MAX_TITLE_LENGTH = 100;
        public const int MAX_TITLE_DESCRIPTION = 450;
        public int id { get; set; }
        public string title { get; set; }
        public string descriptions { get; set; }
        public DateOnly datetime { get; set; }

        public static (Article article, string Error) CreateNew(string title, string description, DateOnly datetime)
        {
            var error = string.Empty;

            if (string.IsNullOrEmpty(title) || title.Length > MAX_TITLE_LENGTH)
            {
                error = $"title can not be empty or longer than {MAX_TITLE_LENGTH}";
            }

            if (string.IsNullOrEmpty(description) || description.Length > MAX_TITLE_DESCRIPTION)
            {
                error = $"descriptions can not be empty or longer than {MAX_TITLE_DESCRIPTION}";
            }

            var article = new Article(title, description, datetime);

            return (article, error);
        }
    }
}
