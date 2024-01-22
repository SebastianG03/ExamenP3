using GuamanDavidP3.Models;
using System.Collections.ObjectModel;

namespace GuamanDavidP3.Views;

public partial class ListTareaPage : ContentPage
{
	public ListTareaPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var listTareas = await App.service.GetTareas();
        var tareas = new ObservableCollection<Tarea>(listTareas);
        listaTareas.ItemsSource = tareas;
    }

 
    private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
    {
        Tarea tarea = e.SelectedItem as Tarea;
        await App.Current.MainPage.Navigation.PushAsync(new DetailsTareaPage(tarea));
    }

    private async void OnClickVolver(object sender, EventArgs e)
    {
        await App.Current.MainPage.Navigation.PopAsync();
    }
}