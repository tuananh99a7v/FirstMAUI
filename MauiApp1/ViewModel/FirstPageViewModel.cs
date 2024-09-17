using System;
using System.ComponentModel;

namespace MauiApp1.ViewModel;

public class FirstPageViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    void OnPropertyChanged(string name) =>
                            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    // public string? Text { get; set; }
    string? text;

    public string? Text {
        get => text;
        set {
            text= value;
            OnPropertyChanged(nameof(Text));
        }
    }

}
