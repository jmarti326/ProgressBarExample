# ProgressBarExample
Xamarin Forms example on how to use and create progress bar.

Xamarin forms progressbar is created by using the progressbar component.
The progressbar increament by decimals where .0 is the lowest value and 1 is the highest. (0% - 100%)
You can increase the progressbar by using:

progressbar_increaseByClick.Progress += .1;

Or you can also use this other example to increase the progressbar by time:
progressbar_increaseByTime.ProgressTo(1, 60000, Easing.Linear);

The first parameter is the highest percentage, the second the amount of time (in milliseconds) it takes for it to get to the highest percentage, and the third parameter is the formula of increment.

For more info:
https://developer.xamarin.com/api/type/Xamarin.Forms.ProgressBar/

