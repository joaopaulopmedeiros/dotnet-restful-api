using AutoMapper;
using Domain;
using Domain.Aggregates.NewsAgreggate;
using Infra.CrossCutting.Utils;
using Presentation.Commom.Messages;
using Presentation.Interfaces;
using Presentation.Views;
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
            var items = await _defaultService.FindAllAsync();
            
            Response response = new Response();
            
            response.Objects = Mapper.Map<IEnumerable<NewsView>>(items);
            
            return response;
        }

        /// <summary>
        ///  Busca por lista de notícias em site da Globo
        /// </summary>
        /// <returns></returns>
        public async Task<IResponse> ScrapAsync()
        {
            var items = await _scraperService.FindAllAsync();

            Response response = new Response();

            response.Objects = Mapper.Map<IEnumerable<NewsView>>(items);
            
            return response;
        }
    }
}
