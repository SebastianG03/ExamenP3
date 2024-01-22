using GuamanDavidP3.Services;
using GuamanDavidP3.Views;

namespace GuamanDavidP3
{
    public partial class App : Application
    {
        public static APIService service { get; set; }
        public App()
        {
            InitializeComponent();
            service = new APIService();
            MainPage = new NavigationPage(new IndexPage());
        }
    }
}
