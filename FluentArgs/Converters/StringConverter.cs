namespace FluentArgs.Converters
{
    public class StringConverter : ArgumentConverter<string>
    {
        protected override Result<string> Parse(string arg)
            => Result.Success(arg);
    }
}
