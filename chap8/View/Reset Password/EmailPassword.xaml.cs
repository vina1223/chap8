namespace chap8.View.Reset_Password;

public partial class EmailPassword : ContentPage
{
	public EmailPassword()
	{
		InitializeComponent();
	}

    public void NewClicked(Object sender, EventArgs e)
    {
        Navigation.PushAsync(new SetNewPassword());
    }
}