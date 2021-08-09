using Presentation.Commom.Messages;
using Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presentation.Facades
{
    public class NewsFacade : INewsFacade
    {
        public async Task<IResponse> FindAllAsync()
        {
            await Task.Delay(1000);
            return new Response();
        }
    }
}
