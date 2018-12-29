namespace FluentArgs.Providers
{
    public class BoolArgProvider : IArgValueProvider<bool>
    {
        public bool GetValue(bool isPresent)
            => isPresent;
    }
}
