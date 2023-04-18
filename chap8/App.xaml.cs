using chap8.View;
using chap8.View.Reset_Password;

namespace chap8;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage =new NavigationPage( new ForgetPassWord());
	}
}
