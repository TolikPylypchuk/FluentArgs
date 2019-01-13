using System;

using FluentArgs.Converters;
using FluentArgs.Providers;

namespace FluentArgs.Builders
{
    public class ArgumentBuilder<T> : NestedBuilder<CommandBuilder>
    {
        internal ArgumentBuilder(CommandBuilder baseBuilder)
            : base(baseBuilder)
        { }

        internal ArgumentDefinition<T> ArgumentDefinition { get; } = new ArgumentDefinition<T>();
        internal ArgumentConverter<T> Converter { get; private set; }
        internal IArgumentValueProvider<T> Provider { get; private set; }
        internal Func<T> DefaultValueProvider { get; private set; }

        public ArgumentBuilder<T> WithName(string name)
        {
            this.ArgumentDefinition.Name = name ?? throw new ArgumentNullException(nameof(name));
            return this;
        }

        public ArgumentBuilder<T> WithShortName(string shortName)
        {
            this.ArgumentDefinition.ShortName = shortName ?? throw new ArgumentNullException(nameof(shortName));
            return this;
        }

        public ArgumentBuilder<T> WithDescription(string description)
        {
            this.ArgumentDefinition.Description = description ?? throw new ArgumentNullException(nameof(description));
            return this;
        }

        public ArgumentBuilder<T> WithPlaceholder(string placeholder)
        {
            this.ArgumentDefinition.Placeholder = placeholder ?? throw new ArgumentNullException(nameof(placeholder));
            return this;
        }

        public ArgumentBuilder<T> WithErrorMessage(string errorMessage)
        {
            this.ArgumentDefinition.Placeholder = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
            return this;
        }

        public ArgumentBuilder<T> WithDefaultValue(T defaultValue)
            => this.WithDefaultValue(() => defaultValue);

        public ArgumentBuilder<T> WithDefaultValue(Func<T> defaultValueProvider)
        {
            this.DefaultValueProvider = defaultValueProvider;
            return this;
        }

        public ArgumentBuilder<T> WithConverter(ArgumentConverter<T> converter)
        {
            this.Converter = converter ?? throw new ArgumentNullException(nameof(converter));
            this.Provider = null;
            return this;
        }

        public ArgumentBuilder<T> WithProvider(IArgumentValueProvider<T> provider)
        {
            this.Provider = provider ?? throw new ArgumentNullException(nameof(provider));
            this.Converter = null;
            return this;
        }
    }
}
