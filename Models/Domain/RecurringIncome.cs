namespace ExpenseCatch.Models.Domain;

class RecurringIncome : RecurringTransaction
{
    public required string Source { get; set; } // e.g. Salary, Rent, etc.
    public bool IsGuaranteed { get; set; }
}
