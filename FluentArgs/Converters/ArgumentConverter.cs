using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentArgs.Converters
{
    public abstract class ArgumentConverter<T>
    {
        protected IList<Func<T, bool>> predicates = new List<Func<T, bool>>();

        public ArgumentConverter<T> WithCondition(Func<T, bool> predicate)
        {
            this.predicates.Add(predicate);
            return this;
        }

        public Result<T> Convert(string arg)
        {
            var result = this.Parse(arg);

            return result.IsSuccess && this.predicates.All(predicate => predicate(result.Value))
                ? result
                : Result.Failure<T>();
        }

        protected abstract Result<T> Parse(string arg);
    }
}
