using System;

namespace FluentArgs.Converters
{
    public class DecimalConverter : ArgumentConverter<decimal>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid decimal number.";

        public DecimalConverter() : base(DefaultErrorMessage) { }

        protected override Result<decimal> Parse(string arg)
            => Decimal.TryParse(arg, out decimal value)
                ? Result.Success(value)
                : Result.Failure<decimal>(this.ErrorMessage);
    }
}
