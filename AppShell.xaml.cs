namespace Organic_Chemistry;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("CharacteristicGroup", typeof(Organic_Chemistry.CharacteristicGroup));
	}
}
