using PixelWiz.Views;

namespace PixelWiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashBoardView();
        }
    }
}
