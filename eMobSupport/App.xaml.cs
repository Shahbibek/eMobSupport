
namespace eMobSupport
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Enable version tracking 
            VersionTracking.Track();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new StartPage()));
        }
    }
}