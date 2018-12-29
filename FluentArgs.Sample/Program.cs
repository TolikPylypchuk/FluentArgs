namespace FluentArgs.Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Args.Builder()
                .AddArg<string>()
                    .WithName("input")
                    .WithShortName("i")
                    .And()
                .AddArg<bool>()
                    .WithName("force")
                    .WithShortName("f")
                    .And()
                .Build(args);
        }
    }
}
