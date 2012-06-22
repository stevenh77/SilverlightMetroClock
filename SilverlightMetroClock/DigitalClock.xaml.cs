using System;
using System.Windows.Threading;

namespace SilverlightMetroClock
{
    public partial class DigitalClock
    {

        public DigitalClock()
        {
            InitializeComponent();

            // updates every minute but perhaps not on the minute :)
            DispatcherTimer timer = new DispatcherTimer {Interval = new TimeSpan(0, 0, 1, 0)};
            timer.Tick += timer_Tick;
            timer.Start();

            UpdateDisplay();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        void UpdateDisplay()
        {
            var now = DateTime.Now;

            TimeTextBlock.Text = now.ToString("HH:mm");
            DayTextBlock.Text = now.ToString("dddd");
            DateTextBlock.Text = now.ToString("MMMM d");
        }
    }
}
