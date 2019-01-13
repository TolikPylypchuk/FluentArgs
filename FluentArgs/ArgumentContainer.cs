using System.Collections;
using System.Linq;

namespace FluentArgs
{
    public abstract class ArgumentContainer
    {
        private protected ArgumentContainer(IEnumerable arguments, ArgumentCommand command)
        {
            this.Arguments = arguments;
            this.Command = command;
        }

        public ArgumentCommand Command { get; }

        private protected IEnumerable Arguments { get; }
        
        public Argument<T> Get<T>(string name)
            => this.Arguments.OfType<Argument<T>>().FirstOrDefault(arg => arg.Definition.Name == name);
    }
}
