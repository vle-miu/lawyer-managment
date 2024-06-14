namespace Lawyer.DomainEntities
{
    public class LawyerOffice : BaseEntity
    {
        public string Name { get; set; }
        public string ImgProfile { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }
        public string Introduction { get; set; }
        public decimal Price { get; set; }
        public string WorkingTime { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string HomePage { get; set; }
        public string Others { get; set; }
    }
}
