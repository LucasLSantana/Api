namespace Estudo.Domain.Domain.Entities
{
    public class User
    {
        public User()
        {
            UserId = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }
        public Guid UserId { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool Active { get; set; }
    }
}