namespace Organic_Chemistry;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();

		CreateCmpBtn.Pressed += async (s, e) => await Shell.Current.GoToAsync("CreatePage");
	}

    
}

