using Domain.Entities.ArenaObjects;
using Domain.Entities.QrCodes;
using Domain.Entities.Relationships.Accesses;
using Domain.Entities.Relationships.Fixtures;
using Domain.Entities.TemporaryTicketAssignments;

namespace Domain.Entities.Fixtures
{
    public class Fixture
    {
        public int Id { get; set; }

        public required string Name { get; set; }
        public DateTime? PausedFrom { get; set; }
        public DateTime? PausedTo { get; set; }
        public string? PauseReason { get; set; }
        public required DateTime CreatedAt { get; set; }

        public required DateTime UpdatedAt { get; set; }

        public required FixtureCategory Category { get; set; }

        public required FixtureDeviceType DeviceType { get; set; }

        public required ArenaObject ArenaObject { get; set; }
        public int ArenaObjectId { get; set; }

        //Relationships
        public ICollection<FixturesXitHubV1> FixturesXitHubV1 { get; set; } = new List<FixturesXitHubV1>();
        public ICollection<AccessesFixtures> AccessFixtures { get; set; } = new List<AccessesFixtures>();
        public ICollection<QrCode> QrCodes { get; set; } = new List<QrCode>();
        public ICollection<TemporaryTicketAssignment> TemporaryTicketAssignments { get; set; } = new List<TemporaryTicketAssignment>();
    }
}
