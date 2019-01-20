using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentArgs.Converters
{
    public abstract class ArgumentConverter<T>
    {
        private string errorMessage;

        protected ArgumentConverter(string errorMessage)
            => this.ErrorMessage = errorMessage;

        protected IList<(Func<T, bool> Predicate, string ErrorMessage)> Predicates { get; } =
            new List<(Func<T, bool> Predicate, string ErrorMessage)>();

        protected string ErrorMessage
        {
            get => this.errorMessage;
            set => this.errorMessage = value ?? throw new ArgumentNullException(nameof(errorMessage));
        }

        public ArgumentConverter<T> WithErrorMessage(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
            return this;
        }

        public ArgumentConverter<T> WithCondition(Func<T, bool> predicate, string errorMessage)
        {
            this.Predicates.Add((predicate, errorMessage));
            return this;
        }

        public Result<T> Convert(string arg)
        {
            var result = this.Parse(arg);

            if (!result.IsSuccess)
            {
                return result;
            }

            var errorMessages = from pred in this.Predicates
                                where !pred.Predicate(result.Value)
                                select pred.ErrorMessage;

            return errorMessages.Count() == 0 ? result : Result.Failure<T>(errorMessages);
        }

        protected abstract Result<T> Parse(string arg);
    }
}
