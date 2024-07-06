namespace NLayer.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime AccountCreatedDate { get; set; }
        public string AccountType { get; set; } //renter or customer
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
