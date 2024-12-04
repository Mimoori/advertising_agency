using Agency.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Core
{
    public interface IArticleService
    {
        Task<Article> GetById(int id);
        IEnumerable<Article> GetAll();
        Task CreateArticle(Article article);
        Task UpdateArticle(Article article);
        Task DeleteArticle(Article article);
    }
}
