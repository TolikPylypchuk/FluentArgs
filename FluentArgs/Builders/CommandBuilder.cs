namespace FluentArgs.Builders
{
    public class CommandBuilder : DerivedBuilder<ArgsBuilder>
    {
        private string command;

        internal CommandBuilder(ArgsBuilder baseBuilder)
            : base(baseBuilder)
        { }

        public CommandBuilder WithName(string name)
        {
            this.command = name;
            return this;
        }
    }
}
