using System.Threading.Tasks;
using ExpenseCatch.Models.Domain;
using Microsoft.AspNetCore.Components;

namespace ExpenseCatch.Presentation.Pages;

public partial class Transactions : ComponentBase
{
    private IQueryable<RecurringTransaction> _transactions = new List<RecurringTransaction>().AsQueryable();
    private IList<RecurringTransaction>? _selectedTransactions;

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        _transactions = new List<RecurringTransaction> 
        {
            new RecurringIncome {
                Name = "Test",
                Description = "Test Description",
                Amount = 120.50,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Pattern = RecurrancePattern.Daily,
                Source = "Job"
            },
            new RecurringIncome {
                Name = "Test2",
                Description = "Test Description2",
                Amount = 120.50,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                Pattern = RecurrancePattern.Daily,
                Source = "Job2"
            }
        }.AsQueryable();

        _selectedTransactions = new List<RecurringTransaction>{ _transactions.FirstOrDefault() };

        StateHasChanged();
    }
}