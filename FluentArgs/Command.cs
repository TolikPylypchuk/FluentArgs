using System.ComponentModel.Design;

namespace FluentArgs
{
    public class Command : ArgsContainer
    {
        internal Command(string name, ServiceContainer argsContainer, Command command)
            : base(argsContainer, command)
        {
            this.Name = name;
        }

        public string Name { get; }
    }
}
