using System;

namespace FluentArgs.Converters
{
    public class ByteConverter : ArgumentConverter<byte>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid number between 0 and 255.";

        public ByteConverter() : base(DefaultErrorMessage) { }

        protected override Result<byte> Parse(string arg)
            => Byte.TryParse(arg, out byte value)
                ? Result.Success(value)
                : Result.Failure<byte>(this.ErrorMessage);
    }
}
