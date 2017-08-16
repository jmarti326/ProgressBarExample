using Xamarin.Forms;

namespace ProgressBarExample
{
    public partial class ProgressBarExamplePage : ContentPage
    {
        public ProgressBarExamplePage()
        {
            InitializeComponent();

            IncreaseProgressBarByTime();
        }

        void Increase_Clicked(object sender, System.EventArgs e)
        {
            progressbar_increaseByClick.Progress += .1;
        }

        void IncreaseProgressBarByTime()
        {
            // The progress bar increase by decimals (doubles) so .1 is 10% and 1 is 100%.
            // Takes 60000 milliseconds (1 minute) to get to 1 (100).
			//(percentage, time to get to the percentage, the matematical process)
			progressbar_increaseByTime.ProgressTo(1, 60000, Easing.Linear);
        }
    }
}
