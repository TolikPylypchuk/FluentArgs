namespace FluentArgs.Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var result = Args.Builder()
                .WithoutCommands()
                    .AddArg<string>()
                        .WithName("input")
                        .WithShortName("i")
                        .WithDescription("The input file.")
                        .WithPlaceholder("file")
                        .And()
                    .AddArg<bool>()
                        .WithName("force")
                        .WithShortName("f")
                        .WithDescription("Forces the execution.")
                        .And()
                    .And()
                .AddCommand("")
                .And()
                .Build(args);
        }
    }
}
