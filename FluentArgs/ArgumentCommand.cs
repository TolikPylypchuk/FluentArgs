using System.Collections;

namespace FluentArgs
{
    public class ArgumentCommand : ArgumentContainer
    {
        internal ArgumentCommand(IEnumerable arguments, ArgumentCommand command)
            : base(arguments, command)
        { }

        public string Name { get; }
        public string Description { get; }
    }
}
