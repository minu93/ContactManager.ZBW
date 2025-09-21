using System;

namespace ContactManager.Domain.Errors
{
    public sealed class DomainValidationException : Exception
    {
        public string? Field { get; }
        public DomainValidationException(string message, string? field = null) : base(message)
            => Field = field;
    }
}
