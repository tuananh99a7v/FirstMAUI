using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace MauiApp1.ViewModel;

public partial class FirstPageViewModel : ObservableObject
{
    public FirstPageViewModel()
    {
        Items = new ObservableCollection<string?>();
    }
    [ObservableProperty]
    ObservableCollection<string?> items;

    [ObservableProperty]
    string? text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrEmpty(Text)) return;

        Items.Add(Text);
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string? s)
    {
        if(Items.Contains(s))
            Items.Remove(s);
    }

}
