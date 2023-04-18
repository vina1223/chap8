namespace chap8.Resources.Styles;

public partial class ChatStyles : ResourceDictionary
{
	public ChatStyles()
	{
		InitializeComponent();
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(new ResourceDictionary());
        }
    }
	
}
