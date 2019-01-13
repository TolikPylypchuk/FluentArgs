namespace FluentArgs.Providers
{
    public class BoolProvider : IArgumentValueProvider<bool>
    {
        public bool GetValue(bool isPresent)
            => isPresent;
    }
}
