using System;
using System.Collections.Generic;
using System.Text;

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
