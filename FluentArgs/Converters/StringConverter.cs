using System;

namespace FluentArgs.Converters
{
    public class StringConverter : ArgumentConverter<string>
    {
        public static readonly string DefaultErrorMessage = String.Empty;

        public StringConverter() : base(DefaultErrorMessage) { }

        protected override Result<string> Parse(string arg)
            => Result.Success(arg);
    }
}
