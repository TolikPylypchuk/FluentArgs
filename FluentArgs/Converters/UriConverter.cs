using System;

namespace FluentArgs.Converters
{
    public class UriConverter : ArgumentConverter<Uri>
    {
        protected override Result<Uri> Parse(string arg)
            => Uri.TryCreate(arg, UriKind.RelativeOrAbsolute, out Uri value)
                ? Result.Success(value)
                : Result.Failure<Uri>();
    }
}
