using System;

namespace FluentArgs.Converters
{
    public class DoubleConverter : ArgumentConverter<double>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid floating-point number.";

        public DoubleConverter() : base(DefaultErrorMessage) { }

        protected override Result<double> Parse(string arg)
            => Double.TryParse(arg, out double value)
                ? Result.Success(value)
                : Result.Failure<double>(this.ErrorMessage);
    }
}
