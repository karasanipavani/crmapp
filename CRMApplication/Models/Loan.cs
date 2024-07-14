namespace CRMApplication.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string Type { get; set; } // Personal or Education
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
