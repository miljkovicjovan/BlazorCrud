namespace BlazorCrud.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Type { get; set; } = "Expense";
        public string Category { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Today;
    }
}
