namespace CRMApplication.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string Type { get; set; } // Debit or Credit
        public int CustomerId { get; set; } 
        public Customer Customer { get; set; }
    }
}
