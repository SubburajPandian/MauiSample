namespace HoneyWellMauiSample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CameraBarcodePage());
        }
    }

}
