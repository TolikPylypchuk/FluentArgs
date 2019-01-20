namespace FluentArgs.Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arguments = Arguments.Builder()
                .AddArguments()
                    .AddArgument<string>()
                        .WithName("input")
                        .WithShortName("i")
                        .WithDescription("The input file")
                        .And()
                    .AddArgument<string>()
                        .WithName("output")
                        .WithShortName("o")
                        .WithDescription("The output file")
                        .WithPlaceholder("file")
                        .And()
                    .AddArgument<int>()
                        .WithName("n")
                        .WithShortName("n")
                        .WithDescription("Some number")
                        .WithPlaceholder("number")
                        .And()
                    .And()
                .Build(args)
                .Value;

            string inputFile = arguments.Get<string>("input").Value;
            string outputFile = arguments.Get<string>("output").Value;
            int n = arguments.Get<int>("n").Value;
        }
    }
}
