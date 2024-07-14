
using System.Collections.Generic;


namespace CRMApplication.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<Card> Cards { get; set; }
        public List<Loan> Loans { get; set; }
        public List<Deposit> Deposits { get; set; }
    }
}
