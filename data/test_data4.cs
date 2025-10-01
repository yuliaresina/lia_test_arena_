using Domain.Entities.AccessAssignments;
using Domain.Entities.Distributors;
using Domain.Entities.Licenses;
using Domain.Entities.Memberships;
using Domain.Entities.Organizations;
using Domain.Entities.QrCodes;

namespace Domain.Entities.ArenaObjects
{
    public class ArenaObject
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string TimeZone { get; set; }

        public Distributor? Distributor { get; set; }

        public int? DistributorId { get; set; }

        public required Organization Organization { get; set; }

        public int OrganizationId { get; set; }
        public bool BilledByOrganization { get; set; } = false;
        public int MembershipLimit { get; set; }

        public required DateTime CreatedAt { get; set; }

        public required DateTime UpdatedAt { get; set; }

        public ICollection<ArenaObjectMembership> ArenaObjectMemberships { get; set; } = new List<ArenaObjectMembership>();
        
        public ICollection<AccessAssignment> AccessAssignments { get; set; } = new List<AccessAssignment>();
        public IEnumerable<QrCode> QrCodes { get; } = new List<QrCode>();

        public ICollection<ArenaObjectLicense> ArenaObjectLicenses { get; set; } = new List<ArenaObjectLicense>();

        //Billing Relationships
        public ArenaObjectBilling? Billing { get; set; }
        public int? ArenaObjectBillingId { get; set; }
        public ArenaObjectVisitAddress? VisitAddress { get; set; }
        public int? ArenaObjectVisitAddressId { get; set; }
        public ArenaObjectDetails? Details { get; set; }
        public int? ArenaObjectDetailsId { get; set; }


    }
}