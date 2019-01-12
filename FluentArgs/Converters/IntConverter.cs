using System;

namespace FluentArgs.Converters
{
    public sealed class IntConverter : ArgumentConverter<int>
    {
        protected override Result<int> Parse(string arg)
            => Int32.TryParse(arg, out int value)
                ? Result.Success(value)
                : Result.Failure<int>();
    }
}
