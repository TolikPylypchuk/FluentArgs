using System;

namespace FluentArgs.Builders
{
    public class ArgBuilder<T> : DerivedBuilder<CommandBuilder>
    {
        private readonly Arg<T> arg = new Arg<T>();

        internal ArgBuilder(CommandBuilder baseBuilder)
            : base(baseBuilder)
        { }

        public ArgBuilder<T> WithDefaultValue(T value)
        {
            this.arg.DefaultValue = value;
            this.arg.HasDefaultValue = true;
            return this;
        }

        public ArgBuilder<T> WithNoDefaultValue()
        {
            this.arg.DefaultValue = default;
            this.arg.HasDefaultValue = false;
            return this;
        }

        public ArgBuilder<T> WithName(string name)
        {
            this.arg.Name = name ?? throw new ArgumentNullException(nameof(name));
            return this;
        }

        public ArgBuilder<T> WithShortName(string shortName)
        {
            this.arg.ShortName = shortName ?? throw new ArgumentNullException(nameof(shortName));
            return this;
        }

        public ArgBuilder<T> WithDescription(string description)
        {
            this.arg.Description = description ?? throw new ArgumentNullException(nameof(description));
            return this;
        }

        public ArgBuilder<T> WithPlaceholder(string placeholder)
        {
            this.arg.Placeholder = placeholder ?? throw new ArgumentNullException(nameof(placeholder));
            return this;
        }

        public ArgBuilder<T> CaseSensitive(bool isCaseSensitive = true)
        {
            this.arg.IsCaseSensitive = isCaseSensitive;
            return this;
        }
    }
}
