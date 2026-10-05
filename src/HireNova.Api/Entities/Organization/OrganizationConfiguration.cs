using HireNova.Api.Entities.OrganizationMembership;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HireNova.Api.Entities.Organization
{
    public class OrganizationConfiguration: IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organizations");
            builder.HasKey((x) => x.Id);
            builder.HasMany<OrganizationMembership>((x) => x.Members);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Website).HasMaxLength(500);
            builder.Property(x => x.Industry).HasMaxLength(200);
        }
    }
}
