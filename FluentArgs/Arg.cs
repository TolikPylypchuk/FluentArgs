namespace FluentArgs
{
    public sealed class Arg<T>
    {
        internal Arg() { }

        internal Arg(string name, string shortName, bool caseSensitive, T value, bool valuePresent)
        {
            this.Name = name;
            this.ShortName = shortName;
            this.Value = value;
            this.ValuePresent = valuePresent;
            this.CaseSensitive = caseSensitive;
        }

        public string Name { get; internal set; }
        public string ShortName { get; internal set; }
        public bool CaseSensitive { get; internal set; } = true;

        public T Value { get; internal set; }
        public bool ValuePresent { get; internal set; }
    }
}
