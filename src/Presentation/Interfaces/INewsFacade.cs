using Presentation.Commom.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface INewsFacade
    {
        public Task<IResponse> FindAllAsync();
    }
}
