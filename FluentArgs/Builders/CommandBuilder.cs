using System;
using System.Collections.Generic;

namespace FluentArgs.Builders
{
    public class CommandBuilder : NestedBuilder<ArgumentsBuilder>
    {
        internal CommandBuilder(ArgumentsBuilder baseBuilder)
            : base(baseBuilder)
        { }

        internal string Name { get; set; }
        internal string Description { get; set; }
        internal List<object> ArgumentBuilders { get; set; }

        public CommandBuilder WithName(string name)
        {
            if (this.Name == String.Empty)
            {
                throw new NotSupportedException("Cannot change the name of the main command.");
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (name == String.Empty)
            {
                throw new ArgumentOutOfRangeException("The empty name is reserved for the main command.");
            }

            this.Name = name;

            return this;
        }

        public CommandBuilder WithDescription(string description)
        {
            this.Description = description ?? throw new ArgumentNullException(nameof(description));
            return this;
        }

        public ArgumentBuilder<T> AddArgument<T>()
        {
            var builder = new ArgumentBuilder<T>(this);
            this.ArgumentBuilders.Add(builder);

            return builder;
        }

        public ArgumentBuilder<T> AddMainArgument<T>()
        {
            var builder = new ArgumentBuilder<T>(this);
            builder.ArgumentDefinition.Name = String.Empty;
            builder.ArgumentDefinition.ShortName = String.Empty;
            this.ArgumentBuilders.Add(builder);

            return builder;
        }
    }
}
