using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace FluentArgs
{
    public abstract class ArgsContainer
    {
        protected readonly ServiceContainer argsContainer = new ServiceContainer();
        protected Command command;

        private protected ArgsContainer(ServiceContainer argsContainer, Command command)
        {
            this.argsContainer = argsContainer;
            this.command = command;
        }

        public Arg<T> Get<T>(string name, bool required = true)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (name == String.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(name));
            }

            var result = ((IEnumerable<Arg<T>>)this.argsContainer.GetService(typeof(T)))
                .FirstOrDefault(arg => arg.Name == name || arg.ShortName == name);

            if (required && result == null)
            {
                throw new ArgAbsentException(name);
            }

            return result;
        }

        public Command GetCommand()
            => this.command;
    }
}
