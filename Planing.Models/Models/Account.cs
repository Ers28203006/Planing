namespace Planing.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Plan Plan { get; set; }
        public int PlanId { get; set; }
    }
}
