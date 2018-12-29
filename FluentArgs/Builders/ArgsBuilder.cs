using System;
using System.Collections;

namespace FluentArgs
{
    public class ArgsBuilder
    {
        public static readonly string DefaultNamePrefix = "--";
        public static readonly string DefaultShortNamePrefix = "-";

        private readonly string[] args;
        private string namePrefix = DefaultNamePrefix;
        private string shortNamePrefix = DefaultShortNamePrefix;

        private readonly ArrayList parsers = new ArrayList();
        
        internal ArgsBuilder(string[] args)
            => this.args = args;

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

        public Args Build()
            => throw new NotImplementedException();

        internal void AddArg<T>(Arg<T> arg)
            => throw new NotImplementedException();
    }
}
