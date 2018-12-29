namespace FluentArgs.Providers
{
    public interface IArgValueProvider<T>
    {
        T GetValue(bool isPresent);
    }
}
