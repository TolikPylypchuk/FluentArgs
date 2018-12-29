using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

using FluentArgs.Builders;
using FluentArgs.Parsers;
using FluentArgs.Providers;

namespace FluentArgs
{
    public sealed class Args
    {
        private readonly ServiceContainer argsContainer = new ServiceContainer();
        private readonly List<string> commands = new List<string>();

        internal Args(ServiceContainer argsContainer, List<string> commands)
        {
            this.argsContainer = argsContainer;
            this.commands = commands;
        }

        public static ArgsBuilder Builder()
        {
            ArgsBuilder builder = new ArgsBuilder();

            builder.AddParser(new StringArgParser());
            builder.AddParser(new IntArgParser());
            builder.AddParser(new DoubleArgParser());
            builder.AddParser(new DateTimeArgParser());
            builder.AddValueProvider(new BoolArgProvider());

            return builder;
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
        
        public string GetCommand(int level = 0)
            => level < 0 || level >= commands.Count
            ? throw new ArgumentOutOfRangeException(nameof(level))
            : this.commands[level];
    }
}
