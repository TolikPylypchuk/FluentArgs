namespace FluentArgs.Builders
{
    public class ArgBuilder<T> : DerivedBuilder<ArgsBuilder>
    {
        private readonly Arg<T> arg = new Arg<T>();

        internal ArgBuilder(ArgsBuilder baseBuilder)
            : base(baseBuilder)
        { }

        public ArgBuilder<T> WithName(string name)
        {
            this.arg.Name = name;
            return this;
        }

        public ArgBuilder<T> WithShortName(string shortName)
        {
            this.arg.ShortName = shortName;
            return this;
        }

        public ArgBuilder<T> CaseSensitive()
        {
            this.arg.CaseSensitive = true;
            return this;
        }

        public ArgBuilder<T> CaseInsensitive()
        {
            this.arg.CaseSensitive = false;
            return this;
        }
    }
}
