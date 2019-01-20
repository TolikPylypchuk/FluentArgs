using System;

namespace FluentArgs.Converters
{
    public class EnumConverter<TEnum> : ArgumentConverter<TEnum>
        where TEnum : struct
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid enumerated value.";

        public EnumConverter() : base(DefaultErrorMessage) { }

        protected override Result<TEnum> Parse(string arg)
            => Enum.TryParse(arg, true, out TEnum value)
                ? Result.Success(value)
                : Result.Failure<TEnum>(this.ErrorMessage);
    }
}
