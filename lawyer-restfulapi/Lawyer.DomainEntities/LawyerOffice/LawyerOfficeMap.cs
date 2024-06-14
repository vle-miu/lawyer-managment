using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lawyer.DomainEntities
{
    public class LawyerOfficeMap
    {
        public LawyerOfficeMap(EntityTypeBuilder<LawyerOffice> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ID);
            entityBuilder.Property(t => t.Name);
            entityBuilder.Property(t => t.ImgProfile);
            entityBuilder.Property(t => t.Address);
            entityBuilder.Property(t => t.Latitude);
            entityBuilder.Property(t => t.Longtitude);
            entityBuilder.Property(t => t.Introduction);
            entityBuilder.Property(t => t.Price);
            entityBuilder.Property(t => t.WorkingTime);
            entityBuilder.Property(t => t.Email);
            entityBuilder.Property(t => t.Phone);
            entityBuilder.Property(t => t.HomePage);
            entityBuilder.Property(t => t.Others);
        }
    }
}
