using Agency.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Database.Repository
{
    public abstract class BaseRepository<Article>
    {
        private ApplicationContext _context;

        protected BaseRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Article> GetAll()
        {
            return _context.article.ToList();
        }

        public async Task<TModel> GetById(int id)
            => await _context.Set<TModel>().AsNoTracking().FirstOrDefaultAsync(p => p.id == id);

        public async Task<TModel> Create(TModel item)
        {
            await _context.Set<TModel>().AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<TModel> Update(TModel item)
        {
            _context.Set<TModel>().Update(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<TModel> Delete(TModel item)
        {
            _context.Set<TModel>().Remove(item);
            await _context.SaveChangesAsync();
            return item;
        }        
    }
}
