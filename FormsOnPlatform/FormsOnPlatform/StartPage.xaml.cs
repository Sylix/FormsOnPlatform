using Xamarin.Forms;

namespace FormsOnPlatform
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();

            // Utilizado para definições de plataforma via code behind.

            //switch (Device.OS)
            //{
            //    case TargetPlatform.Android:
            //        Padding = new Thickness(8);
            //        break;
            //    case TargetPlatform.iOS:
            //        Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case TargetPlatform.Windows:
            //        Padding = new Thickness(12, 8);
            //        break;
            //}

            //Informacao.Text = Device.OnPlatform("Estou no iOS", "Estou no Android", "Estou no Windows");

            //Retangulo.BackgroundColor = Device.OnPlatform(Color.Fuchsia, Color.Green, Color.Blue);
        }
    }
}