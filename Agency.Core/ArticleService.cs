using Agency.Database.EntityModels;
using Agency.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Core
{
    public class ArticleService : IArticleService
    {
        private IArticleRepository _article;
        public ArticleService(IArticleRepository article)
        {
            _article = article;
        }

        public async Task<Article> GetById(int id)
        {
            var article = await _article.GetById(id);
            return article;
        }

        public IEnumerable<Article> GetAll()
        {
            var article = _article.GetAll();
            return article;
        }

        public async Task CreateArticle(Article article)
        {
            var newArticle = Article.CreateNew(article.title, article.descriptions, article.datetime);
            
            await _article.Create(newArticle.article);
        }

        public async Task UpdateArticle (Article article)
        {
            await _article.Update(article);
        }


        public async Task DeleteArticle(Article article)
        {
            await _article.Delete(article);
        }
    }
}
