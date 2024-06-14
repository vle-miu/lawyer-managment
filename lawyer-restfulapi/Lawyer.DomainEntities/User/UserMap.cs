using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Lawyer.DomainEntities
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ID);
            entityBuilder.Property(t => t.UserName);
            entityBuilder.Property(t => t.Password);
            entityBuilder.Property(t => t.Email);
            entityBuilder.Property(t => t.Age);
            entityBuilder.Property(t => t.Address);
            entityBuilder.Property(t => t.FirstName);
            entityBuilder.Property(t => t.LastName);
            entityBuilder.Property(t => t.Role);
            entityBuilder.Property(t => t.CreatedDate);
            entityBuilder.Property(t => t.UpdatedDate);
            entityBuilder.Property(t => t.CreatedUser);
            entityBuilder.Property(t => t.UpdatedUser);
        }
    }
}
