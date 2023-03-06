namespace Organic_Chemistry;

[QueryProperty(nameof(ChGroup), "Group")]
public partial class CreatePage : ContentPage
{
    string chGroup;
    public string ChGroup
    {
        get => chGroup;
        set
        {
            chGroup = value;
        }
    }

    public CreatePage()
	{
		InitializeComponent();
	}
}