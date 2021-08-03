using System;
using System.Collections.Generic;

namespace Dif.Controller
{
    public class DiController : IDiController
    {
        private readonly IDictionary<Type, Type> registeredTypes = new Dictionary<Type, Type>();
        private readonly IDictionary<Type, object> registeredInstances = new Dictionary<Type, object>();

        /// <summary>Register a contract to a type</summary>
        public void Register<TContract, TImplementation>() where TContract : class where TImplementation : class
        {
            this.registeredTypes[typeof(TContract)] = typeof(TImplementation);
        }

        /// <summary>Register a contract to a concrete instance</summary>
        public void Register<TContract>(object instance) where TContract : class
        {
            this.registeredInstances[typeof(TContract)] = instance;
        }

        public TContract Resolve<TContract>() where TContract : class
        {
            return (TContract)this.Resolve(typeof(TContract));
        }

        private object Resolve(Type contract)
        {
            if (this.registeredInstances.ContainsKey(contract))
            {
                return this.registeredInstances[contract];
            }
            return this.ResolveType(contract);
        }

        private object ResolveType(Type contract)
        {
            if (!this.registeredTypes.ContainsKey(contract))
            {
                throw new ArgumentOutOfRangeException($"Type {contract} is not registered!");
            }
            var typeToCreate = this.registeredTypes[contract];
            var constructor = typeToCreate.GetConstructors()[0];
            var constructorParameters = constructor.GetParameters();
            if (constructorParameters.Length == 0)
            {
                return Activator.CreateInstance(typeToCreate);
            }
            var constructorParams = new List<object>(constructorParameters.Length);
            foreach (var parameterInfo in constructorParameters)
            {
                constructorParams.Add(this.Resolve(parameterInfo.ParameterType));
            }
            return constructor.Invoke(constructorParams.ToArray());
        }
    }
}
