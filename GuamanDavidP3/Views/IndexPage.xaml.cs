namespace GuamanDavidP3.Views;

public partial class IndexPage : ContentPage
{
	public IndexPage()
	{
		InitializeComponent();
	}

    private static async void ShowTareas(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PushAsync(new ListTareaPage());
    }

    private static async void AddTarea(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PushAsync(new AddTareaPage());
    }
}