using Domain.Entities.ArenaObjects;
using Domain.Entities.Memberships;

namespace Domain.Entities.Accounts
{
    public class Account
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        // We want to treat emails as case-insensitive. The Email class will handle validation and normalization to support this.
        // Auth0 also expects all emails to be lowercase as well.
        public required Email Email { get; set; }
        public string? KeycloakUserId { get; set; }
        public string? Auth0UserId { get; set; }
        public string? IntercomUserIdentifier { get; set; }

        public required DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public bool IsSuperAdmin { get; set; } = false;
        

        //Relationships
        public ICollection<ArenaObjectMembership> ArenaObjectMemberships { get; set; } = new List<ArenaObjectMembership>();
        public ICollection<DistributorMembership> DistributorMemberships { get; set; } = new List<DistributorMembership>();
    }
}