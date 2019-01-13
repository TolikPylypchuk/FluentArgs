using System.ComponentModel.Design;

namespace FluentArgs
{
    public sealed class Arguments : ArgumentContainer
    {
        internal Arguments(ServiceContainer container, ArgumentCommand command)
            : base(container, command)
        { }
    }
}
