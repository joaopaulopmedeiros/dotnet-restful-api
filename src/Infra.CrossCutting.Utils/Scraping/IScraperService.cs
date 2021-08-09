using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.CrossCutting.Utils
{
    public interface IScraperService
    {
        public Task<IEnumerable<News>> FindAllAsync();
    }
}
