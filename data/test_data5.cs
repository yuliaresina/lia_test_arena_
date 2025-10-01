using Domain.Entities.ArenaObjects;
using Domain.Entities.QrCodes;
using Domain.Entities.Relationships.Fixtures;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Devices.XitHubs
{
    [Index(nameof(Imei), IsUnique = true)]
    public class XitHubV1
    {
        /// <summary>
        /// The Guid is called Uuid because it is referenced as such in its service.
        /// </summary>
        [Key]
        public Guid Uuid { get; set; } = Guid.NewGuid();
        [Required]
        [MaxLength(255)]
        public string Imei { get; set; } = null!;
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public int? ArenaObjectId { get; set; }
        public ArenaObject? ArenaObject { get; set; }

        public ICollection<FixturesXitHubV1> FixturesXitHubV1 { get; set; } = new List<FixturesXitHubV1>();
        public ICollection<QrCode> QrCodes { get; } = new List<QrCode>();
    }
}
