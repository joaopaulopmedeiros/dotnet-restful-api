using System.Collections.Generic;

namespace Presentation.Commom.Messages
{
    public interface IResponse
    {
        public bool Success { get; set; }
        public object Object { get; set; }
        public IEnumerable<object> Objects { get; set; }
        public IEnumerable<object> Errors { get; set; }
    }
}
