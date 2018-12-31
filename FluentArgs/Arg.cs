namespace FluentArgs
{
    public sealed class Arg<T>
    {
        internal Arg() { }

        public T Value { get; internal set; }
        public T DefaultValue { get; internal set; }
        public bool HasDefaultValue { get; internal set; }

        public string Name { get; internal set; }
        public string ShortName { get; internal set; }
        public string Description { get; internal set; }
        public string Placeholder { get; internal set; }
        public bool IsCaseSensitive { get; internal set; } = true;
    }
}
