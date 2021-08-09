using AngleSharp;
using Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infra.CrossCutting.Utils
{
    public class GloboScraperService : IScraperService
    {
        private IBrowsingContext context { get; set; }

        public GloboScraperService()
        {
            var config = Configuration.Default.WithDefaultLoader();
            context = BrowsingContext.New(config);
        }


        public async Task<IEnumerable<News>> FindAllAsync()
        {
            var url = "https://www.globo.com/";

            var document = await context.OpenAsync(url);

            var newsHtml = document.QuerySelectorAll(".highlight__title");

            var results = new List<News>();

            foreach (var item in newsHtml)
            {
                var title = item.InnerHtml;

                 results.Add(new News { Title = title });
            }

            return results;
        }
    }
}