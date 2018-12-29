namespace FluentArgs.Builders
{
    public abstract class DerivedBuilder<TBuilder>
    {
        private readonly TBuilder baseBuilder;

        internal DerivedBuilder(TBuilder baseBuilder)
            => this.baseBuilder = baseBuilder;

        public TBuilder And()
            => this.baseBuilder;
    }
}
