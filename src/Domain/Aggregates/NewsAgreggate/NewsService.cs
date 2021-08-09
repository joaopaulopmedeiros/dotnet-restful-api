using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Aggregates.NewsAgreggate
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _repository;

        public NewsService(INewsRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<object>> findAllAsync()
        {
            return await _repository.findAllAsync();
        }
    }
}
