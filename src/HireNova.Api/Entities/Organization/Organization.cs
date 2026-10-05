using HireNova.Api.Enums;
using HireNova.Api.Entities.OrganizationMembership;

namespace HireNova.Api.Entities.Organization
{
    public class Organization
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Website { get; set; }
        public string? Industry { get; set; }
        public int EmployeeCount { get; set; }
        public OrganizationStatus Status { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public ICollection<OrganizationMembership> Members { get; set; } = [];
        public ICollection<Job> Jobs { get; set; } = [];

    }
}
