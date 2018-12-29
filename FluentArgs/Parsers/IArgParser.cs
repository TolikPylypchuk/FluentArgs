namespace FluentArgs.Parsers
{
    public interface IArgParser<T>
    {
        T Parse(string arg);
    }
}
