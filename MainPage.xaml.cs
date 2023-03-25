namespace Bank;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    private void MoveRegistrationPage(object sender, EventArgs e)
    {
        RegistrationPage page = new RegistrationPage();
        Navigation.PushAsync(page);
    }
}

