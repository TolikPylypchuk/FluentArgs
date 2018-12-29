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

        private readonly ServiceContainer argsContainer = new ServiceContainer();

        private readonly Dictionary<Type, object> parsers = new Dictionary<Type, object>();
        private readonly Dictionary<Type, object> providers = new Dictionary<Type, object>();
        
        private string namePrefix = DefaultNamePrefix;
        private string shortNamePrefix = DefaultShortNamePrefix;

        internal ArgsBuilder()
        { }

        public ArgsBuilder SetNamePrefix(string prefix)
        {
            this.namePrefix = prefix;
            return this;
        }

        public ArgsBuilder SetShortNamePrefix(string prefix)
        {
            this.shortNamePrefix = prefix;
            return this;
        }

        public ArgBuilder<T> AddArg<T>()
            => new ArgBuilder<T>(this);

        public ArgsBuilder AddParser<T>(ArgParser<T> parser)
        {
            this.parsers[typeof(T)] = parser;
            return this;
        }

        public ArgsBuilder AddValueProvider<T>(IArgValueProvider<T> provider)
        {
            this.providers[typeof(T)] = provider;
            return this;
        }

        public ArgsBuildResult Build(string[] args)
            => throw new NotImplementedException();

        internal void AddArg<T>(Arg<T> arg)
            => throw new NotImplementedException();
    }
}
