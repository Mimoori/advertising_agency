using Agency.Data;
using Agency.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agency.Core.NewsService
{
    public class NewsService
    {
        private ApplicationContext _context { get; set; }
        public NewsService(ApplicationContext context) {
            _context = context;
        }

        public async Task<Article> AddNew(Article newData)
        {
            var newNew = new Article { title = newData.title, descriptions = newData.descriptions, datetime = DateOnly.FromDateTime(DateTime.Now)};
            _context.article.Add(newNew);
            await _context.SaveChangesAsync();
            return newNew;
        }
    }
}
