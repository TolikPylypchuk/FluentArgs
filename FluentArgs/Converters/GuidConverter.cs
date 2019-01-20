using System;

namespace FluentArgs.Converters
{
    public class GuidConverter : ArgumentConverter<Guid>
    {
        public static readonly string DefaultErrorMessage = "The argument must be a valid GUID.";

        public GuidConverter() : base(DefaultErrorMessage) { }

        protected override Result<Guid> Parse(string arg)
            => Guid.TryParse(arg, out Guid value)
                ? Result.Success(value)
                : Result.Failure<Guid>(this.ErrorMessage);
    }
}
