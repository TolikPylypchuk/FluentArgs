using System.ComponentModel.Design;

using FluentArgs.Builders;
using FluentArgs.Parsers;
using FluentArgs.Providers;

namespace FluentArgs
{
    public sealed class Args : ArgsContainer
    {
        internal Args(ServiceContainer argsContainer, Command command)
            : base(argsContainer, command)
        { }

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
    }
}
