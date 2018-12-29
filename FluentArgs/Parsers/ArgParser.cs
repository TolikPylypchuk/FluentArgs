using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentArgs.Parsers
{
    public abstract class ArgParser<T>
    {
        protected IList<Func<T, bool>> predicates = new List<Func<T, bool>>();

        public ArgParser<T> WithCondition(Func<T, bool> predicate)
        {
            this.predicates.Add(predicate);
            return this;
        }

        public ParseResult<T> ParseAndCheck(string arg)
        {
            var result = this.Parse(arg);

            return result.IsSuccess && this.predicates.All(predicate => predicate(result.Value))
                ? result
                : ParseResult.Failure<T>();
        }

        protected abstract ParseResult<T> Parse(string arg);
    }
}
