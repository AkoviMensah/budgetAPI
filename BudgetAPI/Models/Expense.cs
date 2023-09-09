namespace BudgetAPI.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public int BudgetId { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }

    }
}
