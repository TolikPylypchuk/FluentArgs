using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

using FluentArgs.Parsers;
using FluentArgs.Providers;

namespace FluentArgs.Builders
{
    public class ArgsBuilder
    {
        public static readonly string DefaultNamePrefix = "--";
        public static readonly string DefaultShortNamePrefix = "-";
        public static readonly bool DefaultCaseSensitivity = true;

        private readonly ServiceContainer argsContainer = new ServiceContainer();

        private readonly Dictionary<Type, object> parsers = new Dictionary<Type, object>();
        private readonly Dictionary<Type, object> providers = new Dictionary<Type, object>();
        
        private string namePrefix = DefaultNamePrefix;
        private string shortNamePrefix = DefaultShortNamePrefix;
        private bool isCaseSensitive = DefaultCaseSensitivity;

        internal ArgsBuilder()
        { }

        public ArgsBuilder SetNamePrefix(string prefix)
        {
            this.namePrefix = prefix ?? throw new ArgumentNullException(nameof(prefix));
            return this;
        }

        public ArgsBuilder SetShortNamePrefix(string prefix)
        {
            this.shortNamePrefix = prefix ?? throw new ArgumentNullException(nameof(prefix));
            return this;
        }

        public ArgsBuilder SetCaseSensitivity(bool isCaseSensitive)
        {
            this.isCaseSensitive = isCaseSensitive;
            return this;
        }

        public ArgsBuilder AddParser<T>(ArgParser<T> parser)
        {
            this.parsers[typeof(T)] = parser ?? throw new ArgumentNullException(nameof(parser));
            return this;
        }

        public ArgsBuilder AddValueProvider<T>(IArgValueProvider<T> provider)
        {
            this.providers[typeof(T)] = provider ?? throw new ArgumentNullException(nameof(provider));
            return this;
        }

        public CommandBuilder AddCommand(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (name == String.Empty)
            {
                throw new ArgumentOutOfRangeException(nameof(name));
            }

            return new CommandBuilder(this, name);
        }

        public CommandBuilder WithoutCommands()
            => new CommandBuilder(this, null);

        public ArgsBuildResult Build(string[] args)
            => throw new NotImplementedException();
    }
}
