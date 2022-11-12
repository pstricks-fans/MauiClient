using CommunityToolkit.Mvvm.ComponentModel;
using MauiClient.Models;
using MauiClient.Services;

namespace MauiClient.ViewModels;

[QueryProperty(nameof(Monkey), nameof(Monkey))]
public partial class DetailViewModel : ObservableObject
{
    private readonly MonkeyService service;
    public DetailViewModel(MonkeyService service)
    {
        this.service = service;
    }


    [ObservableProperty]
    Monkey monkey = default!;
}
