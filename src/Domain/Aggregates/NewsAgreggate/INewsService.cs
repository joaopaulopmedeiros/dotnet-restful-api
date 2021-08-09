using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggregates.NewsAgreggate
{
    public interface INewsService
    {
        Task<IEnumerable<object>> findAllAsync();
    }
}
