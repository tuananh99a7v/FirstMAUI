using MauiApp1.ViewModel;

namespace MauiApp1;

public partial class FirstPage : ContentPage
{
	public FirstPage(FirstPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

