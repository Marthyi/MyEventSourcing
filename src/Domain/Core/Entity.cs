using System;

namespace Domain
{
    public record Entity<TId> : IIdentity<TId>
    {       
        public TId Id { get; init; }

        public DateTime CreationDate { get; init; }

    }
}
