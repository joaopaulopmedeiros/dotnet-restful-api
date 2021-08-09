using Presentation.Commom.Messages;
using System.Threading.Tasks;

namespace Presentation.Interfaces
{
    public interface INewsFacade
    {
        public Task<IResponse> FindAllAsync();
    }
}
