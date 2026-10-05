using 

namespace HireNova.Api.Entities.OrganizationMembership
{
    public class OrganizationMembership
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public Guid OrganizationId{ get; set; }
        public Organization Organization { get; set; } = null!;
    }
}
