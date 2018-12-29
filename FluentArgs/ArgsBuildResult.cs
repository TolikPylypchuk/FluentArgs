namespace FluentArgs
{
    public sealed class ArgsBuildResult
    {
        public Args Args { get; }
        public bool IsSuccess { get; }

        private ArgsBuildResult(Args args, bool isSuccess)
        {
            this.Args = args;
            this.IsSuccess = isSuccess;
        }

        internal static ArgsBuildResult Success(Args args)
            => new ArgsBuildResult(args, true);

        internal static ArgsBuildResult Failure()
            => new ArgsBuildResult(null, false);
    }
}
