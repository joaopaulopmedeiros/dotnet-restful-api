using Domain;
using Domain.Aggregates.NewsAgreggate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class NewsRepository : INewsRepository
    {
        private readonly NewsContext _context;

        public NewsRepository(NewsContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<News>> findAllAsync()
        {
            return await _context.News.ToListAsync();
        }

    }
}
