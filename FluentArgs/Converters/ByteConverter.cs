using System;

namespace FluentArgs.Converters
{
    public class ByteConverter : ArgumentConverter<byte>
    {
        protected override Result<byte> Parse(string arg)
            => Byte.TryParse(arg, out byte value)
                ? Result.Success(value)
                : Result.Failure<byte>();
    }
}
