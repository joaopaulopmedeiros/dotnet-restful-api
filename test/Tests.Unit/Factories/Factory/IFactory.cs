using System.Collections.Generic;

namespace Tests.Factories.Interfaces
{
    /// <summary>
    /// Contrato para implementação de uma Factory
    /// </summary>
    public interface IFactory<T>
    {
        IEnumerable<T> Create(int quantity);
        T Create();
    }
}
