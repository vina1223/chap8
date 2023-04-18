using chap8.Resources.Styles;

namespace chap8.View;

public partial class ChatView : ContentPage
{
	public ChatView()
	{
		InitializeComponent();
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new ChatStyles());
        }
    }
}