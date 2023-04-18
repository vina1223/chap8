namespace chap8.View.Reset_Password;

public partial class ForgetPassWord : ContentPage
{
	public ForgetPassWord()
	{
		InitializeComponent();
	}

	public void NewClicked(Object sender, EventArgs e)
	{
		Navigation.PushAsync(new EmailPassword());
	}
}