using System.ComponentModel.Design;

namespace FluentArgs
{
    public class ArgumentCommand : ArgumentContainer
    {
        internal ArgumentCommand(ServiceContainer container, ArgumentCommand command)
            : base(container, command)
        { }

        public string Name { get; }
    }
}
