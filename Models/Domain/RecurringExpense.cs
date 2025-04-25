namespace ExpenseCatch.Models.Domain;

class RecurringExpense : RecurringTransaction
{
    public required string Payee { get; set; } // e.g. Rent, Utilities, etc.
    public required string PaymentMethod { get; set; }
    public bool AutoRenew { get; set; }
}
