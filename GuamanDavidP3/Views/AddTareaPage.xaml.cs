using GuamanDavidP3.Models;

namespace GuamanDavidP3.Views;

public partial class AddTareaPage : ContentPage
{
    private Tarea _tarea;
	public AddTareaPage()
	{
		InitializeComponent();
	}

    private async void OnClickedGuardarTarea(object sender, EventArgs e)
    {
        if(_tarea != null)
        {
            string Title = Nombre.Text;
            string Status = Estado.Text;
            string Description = Descripcion.Text;
        } else
        {
            Tarea tarea = new Tarea
            {
                Id = 0,
                Title = Nombre.Text,
                Status = Estado.Text,
                Description = Descripcion.Text
            };

            await App.service.PostTarea(tarea);
            await App.Current.MainPage.Navigation.PopAsync();
        }

    }
}