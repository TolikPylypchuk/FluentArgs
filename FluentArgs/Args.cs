using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace FluentArgs
{
    public class Args
    {
        private readonly ServiceContainer argsContainer = new ServiceContainer();
        private readonly List<string> commands = new List<string>();

        internal Args(ServiceContainer argsContainer, List<string> commands)
        {
            this.argsContainer = argsContainer;
            this.commands = commands;
        }

        public static ArgsBuilder Builder(string[] args)
            => new ArgsBuilder(args);

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
        
        public string GetCommand(int level = 0)
            => level < 0 || level >= commands.Count
            ? throw new ArgumentOutOfRangeException(nameof(level))
            : this.commands[level];
    }
}
