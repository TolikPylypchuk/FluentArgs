namespace FluentArgs
{
    public sealed class Argument<T>
    {
        internal Argument(ArgumentDefinition<T> definition, T value, bool isValueDefault)
        {
            this.Definition = definition;
            this.Value = value;
            this.IsValueDefault = isValueDefault;
        }

        public ArgumentDefinition<T> Definition { get; }
        public string Name => this.Definition.Name;
        public T Value { get; }
        public bool IsValueDefault { get; }

    }
}
