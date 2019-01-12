using System;

namespace FluentArgs
{
    public abstract class ArgumentContainer
    {
        private protected ArgumentContainer()
        { }

        public ArgumentCommand GetCommand()
            => throw new NotImplementedException();

        public Argument<T> Get<T>(string name)
            => throw new NotImplementedException();
    }
}
