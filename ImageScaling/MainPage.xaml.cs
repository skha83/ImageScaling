namespace ImageScaling
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void StartButton_Clicked(object sender, EventArgs e)
        {
            logoImage.HorizontalOptions = LayoutOptions.Start;
            smallLogoImage.HorizontalOptions = LayoutOptions.Start;
        }

        private void CenterButton_Clicked(object sender, EventArgs e)
        {
            logoImage.HorizontalOptions = LayoutOptions.Center;
            smallLogoImage.HorizontalOptions = LayoutOptions.Center;
        }

        private void EndButton_Clicked(object sender, EventArgs e)
        {
            logoImage.HorizontalOptions = LayoutOptions.End;
            smallLogoImage.HorizontalOptions = LayoutOptions.End;
        }

        private void FillButton_Clicked(object sender, EventArgs e)
        {
            logoImage.HorizontalOptions = LayoutOptions.Fill;
            smallLogoImage.HorizontalOptions = LayoutOptions.Fill;
        }
    }

}
