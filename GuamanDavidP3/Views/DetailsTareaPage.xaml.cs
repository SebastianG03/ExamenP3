using GuamanDavidP3.Models;

namespace GuamanDavidP3.Views;

public partial class DetailsTareaPage : ContentPage
{
    public DetailsTareaPage()
    {
        InitializeComponent();
    }

    private async void OnClickVolver(object sender, EventArgs e) =>
        await App.Current.MainPage.Navigation.PopAsync();


    private async void OnClickBuscar(object sender, EventArgs e)
    {
        string nombre = Nombre.Text;
        string estado = Estado.Text;

        if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(estado))
        {
            Tarea content = await App.service.BuscarTarea(nombre, estado);
            Contenido.Text = String.Concat(
                "Nombre: " + content.Nombre + Environment.NewLine + 
                "Estado: " + content.Estado + Environment.NewLine +
                "Descripcion: " + content.Descripcion + Environment.NewLine
                );
        }
    }
}