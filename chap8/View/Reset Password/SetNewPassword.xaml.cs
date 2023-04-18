namespace chap8.View.Reset_Password;

public partial class SetNewPassword : ContentPage
{
	public SetNewPassword()
	{
		InitializeComponent();
	}

    public void NewClicked(Object sender, EventArgs e)
    {
        Navigation.PushAsync(new PasswordSuccessfull());
    }
}