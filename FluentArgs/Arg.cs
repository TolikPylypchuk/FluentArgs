namespace FluentArgs
{
    public class Arg<T>
    {
        internal Arg() { }

        internal Arg(string name, string shortName, bool caseInsensitive, T value, bool valuePresent)
        {
            this.Name = name;
            this.ShortName = shortName;
            this.Value = value;
            this.ValuePresent = valuePresent;
            this.CaseInsensitive = caseInsensitive;
        }

        public string Name { get; internal set; }
        public string ShortName { get; internal set; }
        public bool CaseInsensitive { get; internal set; }

        public T Value { get; internal set; }
        public bool ValuePresent { get; internal set; }
    }
}
