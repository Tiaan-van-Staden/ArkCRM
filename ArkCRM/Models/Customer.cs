namespace ArkCRM.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = "";
        public string Address { get; set; } = "";
        public int? ContactNumber { get; set; }
        public string? Email { get; set; } = "";
        public int? VatNumber { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
