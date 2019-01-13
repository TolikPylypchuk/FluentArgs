namespace FluentArgs.Builders
{
    public abstract class NestedBuilder<TBuilder>
    {
        private protected TBuilder baseBuilder;

        private protected NestedBuilder(TBuilder baseBuilder)
            => this.baseBuilder = baseBuilder;

        public TBuilder And()
            => this.baseBuilder;
    }
}
