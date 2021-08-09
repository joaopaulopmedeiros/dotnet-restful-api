using Domain.Aggregates.NewsAgreggate;
using Infra.CrossCutting.Utils;
using Presentation.Commom.Messages;
using Presentation.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Facades
{
    public class NewsFacade : INewsFacade
    {
        private readonly INewsService _defaultService;
        private readonly IScraperService _scraperService;

        public NewsFacade(INewsService defaultService, IScraperService scraperService)
        {
            _defaultService = defaultService;
            _scraperService = scraperService;
        }

        /// <summary>
        ///  Busca por lista de notícias armazenadas em banco de dados
        /// </summary>
        /// <returns></returns>
        public async Task<IResponse> FindAllAsync()
        {
            Response response = new Response();
            response.Objects = await _defaultService.FindAllAsync();
            return response;
        }

        /// <summary>
        ///  Busca por lista de notícias em site da Globo
        /// </summary>
        /// <returns></returns>
        public async Task<IResponse> ScrapAsync()
        {
            Response response = new Response();
            response.Objects =  await _scraperService.FindAllAsync();
            return response;
        }
    }
}
