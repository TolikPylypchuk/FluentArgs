using System;

namespace FluentArgs.Builders
{
    public class CommandBuilder : DerivedBuilder<ArgsBuilder>
    {
        private readonly string commandName;

        internal CommandBuilder(ArgsBuilder baseBuilder, string commandName)
            : base(baseBuilder)
        {
            this.commandName = commandName;
        }

        public ArgBuilder<T> AddArg<T>()
            => new ArgBuilder<T>(this);

        internal void AddArg<T>(Arg<T> arg)
            => throw new NotImplementedException();
    }
}
