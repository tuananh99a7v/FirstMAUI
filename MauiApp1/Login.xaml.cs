namespace MauiApp1;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

	private async void OnLoginButtonClicked(object sender, EventArgs e)
	{
		string username = UsernameEntry.Text;
		string password = PasswordEntry.Text;

		// Simple login logic
		if (username == "admin" && password == "1234")
		{
			// Login success
			ErrorMessageLabel.IsVisible = false;
			await DisplayAlert("Success", "Login Successful!", "OK");

			await Navigation.PushAsync(new MainPage());
		}
		else
		{
			// Login failed
			ErrorMessageLabel.Text = "Invalid username or password.";
			ErrorMessageLabel.IsVisible = true;
		}
	}
}