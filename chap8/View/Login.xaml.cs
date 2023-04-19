
using AndroidX.Annotations;

namespace chap8.View;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}


    private void ChangeStyleButtonClicked(object sender, EventArgs e)
	{
		string a = "Vinay@gmail.com";
		string b = "Vinay#123";
		string userName = Username.Text;
		string password = Password.Text;
		if(userName ==a && password==b)
		{
            
        }
		else
		{
			Resources["DefaultLabelStyle"] = Resources["LabelStyle"];
        }
    }

}