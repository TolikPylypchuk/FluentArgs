namespace FluentArgs
{
    public class ArgBuilder<T>
    {
        private readonly ArgsBuilder baseBuilder;
        private readonly Arg<T> arg = new Arg<T>();

        internal ArgBuilder(ArgsBuilder baseBuilder)
            => this.baseBuilder = baseBuilder;

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

        public ArgsBuilder And()
        {
            this.baseBuilder.AddArg(this.arg);
            return this.baseBuilder;
        }
    }
}
