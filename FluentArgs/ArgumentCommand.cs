using System.Collections.Generic;

namespace FluentArgs
{
    public class ArgumentCommand : ArgumentContainer
    {
        internal ArgumentCommand(IEnumerable<object> arguments, ArgumentCommand command)
            : base(arguments, command)
        { }

        public string Name { get; }
        public string Description { get; }
    }
}
