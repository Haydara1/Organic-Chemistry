namespace Organic_Chemistry;

public partial class CharacteristicGroup : ContentPage
{
	public CharacteristicGroup()
	{
		InitializeComponent();

		AH.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.AcidHalide}");
		AL.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Alcohol}");
		AD.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Aldehyde}");
		AMD.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Amide}");
		AMN.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Amine}");
		CA.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.CarboxylicAcid}");
		ES.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Ester}");
		KE.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Ketone}");
		NI.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Nitrile}");
		SU.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.SulfonicAcid}");
		TH.Pressed += async (s, e) => await Shell.Current.GoToAsync($"CreatePage?Group={Organic_Chemistry.Groups.Thiol}");
    }
}