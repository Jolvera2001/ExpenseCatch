using LiteDB;

namespace ExpenseCatch.Models.Domain;

public abstract class RecurringTransaction
{
    [BsonId]
    public ObjectId Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public string? Notes { get; set; }
    public required decimal Amount { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required RecurrancePattern Pattern { get; set; }
}
