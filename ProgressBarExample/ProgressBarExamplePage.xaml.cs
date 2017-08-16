using Xamarin.Forms;

namespace ProgressBarExample
{
    public partial class ProgressBarExamplePage : ContentPage
    {
        public ProgressBarExamplePage()
        {
            InitializeComponent();
        }

        void Increase_Clicked(object sender, System.EventArgs e)
        {
            progressbar1.Progress += .1;
        }
    }
}
