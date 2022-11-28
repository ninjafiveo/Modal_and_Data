namespace Modal_and_Data;

public partial class Animal : ContentPage
{
	public Animal()
	{
		InitializeComponent();
	}

	private void BackButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PopModalAsync();
	}
}