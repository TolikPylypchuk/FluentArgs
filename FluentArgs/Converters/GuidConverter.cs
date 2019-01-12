using System;

namespace FluentArgs.Converters
{
    public class GuidConverter : ArgumentConverter<Guid>
    {
        protected override Result<Guid> Parse(string arg)
            => Guid.TryParse(arg, out Guid value)
                ? Result.Success(value)
                : Result.Failure<Guid>();
    }
}
