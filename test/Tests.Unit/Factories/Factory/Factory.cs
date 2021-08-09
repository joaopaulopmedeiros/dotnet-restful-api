using System;
using System.Collections.Generic;
using Tests.Factories.Interfaces;

namespace Tests.Factories
{
    public class Factory<T> : IFactory<T> where T : class
    {
        public int PreDefinedId { get; set; }
        public bool IsPreDefinedId { get; set; } = false;

        /// <summary>
        /// Cria um objeto com o Id pré-definido
        /// </summary>
        /// 
        public Factory<T> WithRandomId()
        {
            this.IsPreDefinedId = false;
            return this;
        }
        /// <summary>
        /// Cria um objeto com o Id aleatório
        /// </summary>
        /// 
        public Factory<T> WithPreDefinedId(int id)
        {
            this.IsPreDefinedId = true;
            this.PreDefinedId = id;
            return this;
        }

        /// <summary>
        /// Cria lista de entidades
        /// </summary>
        /// 
        public IEnumerable<T> Create(int quantity)
        {
            List<T> Models = new List<T>();

            for (var i = 0; i < quantity; i++)
            {
                Models.Add(GetModel());
            }

            return Models;
        }

        /// <summary>
        /// Cria entidade única
        /// </summary>
        public T Create()
        {
            return GetModel();
        }

        /// <summary>
        /// Retorna model com base em sua factory.
        /// Segue padrão de namespace Tests.Factories.NomeEntidadeFactory
        /// </summary>
        public T GetModel()
        {
            try
            {
                string prefix = typeof(T).Name;

                string factoryName = $"Tests.Factories.{prefix}Factory";

                T Model;

                SetExtraProperties(factoryName);

                Model = Type.GetType(factoryName).GetMethod("Definition").Invoke(null, null) as T;

                return Model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SetExtraProperties(string factoryName)
        {
            if (IsPreDefinedId)
            {
                Type.GetType(factoryName).GetProperty("id").SetValue(null, PreDefinedId);
            }
        }
    }
}
