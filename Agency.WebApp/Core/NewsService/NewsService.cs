using Agency.WebApp.Data;
using Agency.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Agency.Core.NewsService
{
    public class NewsService
    {
        private ApplicationDbContext _context { get; set; }
        public NewsService(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<Article> AddNew(Article newData)
        {
            var newNew = new Article { title = newData.title, descriptions = newData.descriptions, datetime = DateOnly.FromDateTime(DateTime.Now)};
            _context.articles.Add(newNew);
            await _context.SaveChangesAsync();
            return newNew;
        }
    }
}
