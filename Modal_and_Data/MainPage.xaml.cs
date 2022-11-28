namespace Modal_and_Data;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void BtnGoToAnimalPage_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new Animal());
	}
}

