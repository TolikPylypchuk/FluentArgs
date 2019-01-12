﻿using System;

namespace FluentArgs.Parsers
{
    public class BoolConverter : ArgumentConverter<bool>
    {
        protected override Result<bool> Parse(string arg)
            => Boolean.TryParse(arg, out bool value)
                ? Result.Success(value)
                : Result.Failure<bool>();
    }
}