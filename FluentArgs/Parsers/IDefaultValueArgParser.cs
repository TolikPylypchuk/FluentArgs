namespace FluentArgs.Parsers
{
    public interface IDefaultValueArgParser<T>
    {
        T Parse(bool isPresent);
    }
}
