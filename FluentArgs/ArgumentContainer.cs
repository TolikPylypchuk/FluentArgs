using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace FluentArgs
{
    public abstract class ArgumentContainer
    {
        private protected ArgumentContainer(ServiceContainer container, ArgumentCommand command)
        {
            this.Container = container;
            this.Command = command;
        }

        public ArgumentCommand Command { get; }

        private protected ServiceContainer Container { get; }
        
        public Argument<T> Get<T>(string name)
            => ((IEnumerable<Argument<T>>)this.Container.GetService(typeof(IEnumerable<Argument<T>>)))
                .FirstOrDefault(arg => arg.Definition.Name == name);
    }
}
