namespace FluentArgs.Providers
{
    public interface IArgumentValueProvider<T>
    {
        T GetValue(bool isPresent);
    }
}
