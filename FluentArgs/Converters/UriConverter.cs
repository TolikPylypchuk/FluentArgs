using System;

namespace FluentArgs.Converters
{
    public class UriConverter : ArgumentConverter<Uri>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid URI.";

        public UriConverter() : base(DefaultErrorMessage) { }

        protected override Result<Uri> Parse(string arg)
            => Uri.TryCreate(arg, UriKind.RelativeOrAbsolute, out Uri value)
                ? Result.Success(value)
                : Result.Failure<Uri>(this.ErrorMessage);
    }
}
