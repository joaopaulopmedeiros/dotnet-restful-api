using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Aggregates.NewsAgreggate
{
    public interface INewsRepository
    {
        Task<IEnumerable<News>> FindAllAsync();
    }
}