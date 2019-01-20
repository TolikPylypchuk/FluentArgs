using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentArgs
{
    public abstract class ArgumentContainer
    {
        private protected ArgumentContainer(IEnumerable<object> arguments, ArgumentCommand command)
        {
            this.Arguments = arguments;
            this.Command = command;
        }

        public ArgumentCommand Command { get; }

        private protected IEnumerable<object> Arguments { get; }
        
        public Argument<T> Get<T>(string name)
            => name != null
                ? this.Arguments.OfType<Argument<T>>().FirstOrDefault(arg => arg.Definition.Name == name)
                : throw new ArgumentNullException(nameof(name));

        public Argument<T> GetMain<T>()
            => this.Get<T>(String.Empty);
    }
}
