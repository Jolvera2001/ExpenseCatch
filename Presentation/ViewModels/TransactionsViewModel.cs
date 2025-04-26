using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ExpenseCatch.Presentation.ViewModels;

public partial class TransactionsViewModel: ObservableObject
{
    [ObservableProperty]
    private string? _test;
}
