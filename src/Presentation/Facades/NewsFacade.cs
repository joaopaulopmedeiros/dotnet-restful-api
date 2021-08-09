using Domain.Aggregates.NewsAgreggate;
using Presentation.Commom.Messages;
using Presentation.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Facades
{
    public class NewsFacade : INewsFacade
    {
        private readonly INewsService _service;

        public NewsFacade(INewsService service)
        {
            _service = service;
        }

        public async Task<IResponse> FindAllAsync()
        {
            Response response = new Response();
            response.Objects = await _service.findAllAsync();
            return response;
        }
    }
}
