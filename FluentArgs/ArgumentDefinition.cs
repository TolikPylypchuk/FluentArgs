namespace FluentArgs
{
    public sealed class ArgumentDefinition<T>
    {
        public string Name { get; internal set; }
        public string ShortName { get; internal set; }
        public string Description { get; internal set; }
        public string Placeholder { get; internal set; }
        public string ErrorMessage { get; internal set; }

        public T DefaultValue { get; internal set; }
    }
}
