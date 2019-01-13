using System;
using System.Collections.Generic;
using System.Linq;

using FluentArgs.Converters;
using FluentArgs.Providers;

namespace FluentArgs.Builders
{
    public class ArgumentsBuilder
    {
        private string namePrefix = Arguments.DefaultNamePrefix;
        private string shortNamePrefix = Arguments.DefaultShortNamePrefix;

        private readonly List<object> commandBuilders = new List<object>();
        private readonly List<object> converters = new List<object>();
        private readonly List<object> providers = new List<object>();

        internal ArgumentsBuilder() { }

        public ArgumentsBuilder WithNamePrefix(string namePrefix)
        {
            this.namePrefix = namePrefix ?? throw new ArgumentNullException(nameof(namePrefix));
            return this;
        }

        public ArgumentsBuilder WithShortNamePrefix(string shortNamePrefix)
        {
            this.shortNamePrefix = shortNamePrefix ?? throw new ArgumentNullException(nameof(shortNamePrefix));
            return this;
        }

        public ArgumentsBuilder WithConverter<T>(ArgumentConverter<T> converter)
        {
            this.RemoveConverter<T>();
            this.RemoveProvider<T>();
            this.converters.Add(converter ?? throw new ArgumentNullException(nameof(converter)));
            return this;
        }

        public ArgumentsBuilder WithoutConverter<T>()
        {
            this.RemoveConverter<T>();
            return this;
        }

        public ArgumentsBuilder WithProvider<T>(IArgumentValueProvider<T> provider)
        {
            this.RemoveConverter<T>();
            this.RemoveProvider<T>();
            this.providers.Add(provider ?? throw new ArgumentNullException(nameof(provider)));
            return this;
        }

        public ArgumentsBuilder WithoutProvider<T>()
        {
            this.RemoveProvider<T>();
            return this;
        }

        public CommandBuilder AddCommand()
        {
            var builder = new CommandBuilder(this);
            this.commandBuilders.Add(builder);
            return builder;
        }

        public CommandBuilder AddArguments()
        {
            var builder = new CommandBuilder(this) { Name = String.Empty };
            this.commandBuilders.Add(builder);
            return builder.WithName(String.Empty);
        }

        public Arguments Build(string[] args)
            => throw new NotImplementedException();

        private void RemoveConverter<T>()
            => this.converters.RemoveAll(c => typeof(ArgumentConverter<T>).IsAssignableFrom(c.GetType()));

        private void RemoveProvider<T>()
            => this.providers.RemoveAll(p => typeof(IArgumentValueProvider<T>).IsAssignableFrom(p.GetType()));
    }
}
