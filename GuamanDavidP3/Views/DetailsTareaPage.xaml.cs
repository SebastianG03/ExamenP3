using GuamanDavidP3.Models;

namespace GuamanDavidP3.Views;

public partial class DetailsTareaPage : ContentPage
{
	Tarea _tarea;
	public DetailsTareaPage(Tarea tarea)
	{
		InitializeComponent();
		_tarea = tarea;
	}
}