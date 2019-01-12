using System;

namespace FluentArgs.Converters
{
    public class EnumConverter<TEnum> : ArgumentConverter<TEnum>
        where TEnum : struct
    {
        protected override Result<TEnum> Parse(string arg)
            => Enum.TryParse(arg, true, out TEnum value)
                ? Result.Success(value)
                : Result.Failure<TEnum>();
    }
}
