using System.Collections.Generic;

using FluentArgs.Builders;
using FluentArgs.Converters;
using FluentArgs.Providers;

namespace FluentArgs
{
    public sealed class Arguments : ArgumentContainer
    {
        public static readonly string DefaultNamePrefix = "--";
        public static readonly string DefaultShortNamePrefix = "-";

        internal Arguments(IEnumerable<object> arguments, ArgumentCommand command)
            : base(arguments, command)
        { }

        public static ArgumentsBuilder Builder()
            => new ArgumentsBuilder()
                .WithConverter(new StringConverter())
                .WithConverter(new IntConverter())
                .WithConverter(new LongConverter())
                .WithConverter(new ByteConverter())
                .WithConverter(new DoubleConverter())
                .WithConverter(new CharConverter())
                .WithConverter(new DateTimeConverter())
                .WithConverter(new TimeSpanConverter())
                .WithConverter(new UriConverter())
                .WithConverter(new GuidConverter())
                .WithProvider(new BoolProvider());
    }
}
