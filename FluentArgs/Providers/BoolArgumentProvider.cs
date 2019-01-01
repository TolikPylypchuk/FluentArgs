namespace FluentArgs.Providers
{
    public class BoolArgumentProvider : IArgumentValueProvider<bool>
    {
        public bool GetValue(bool isPresent)
            => isPresent;
    }
}
