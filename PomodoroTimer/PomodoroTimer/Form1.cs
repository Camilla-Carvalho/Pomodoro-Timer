using System;
using System.Timers;
using System.Windows.Forms;

namespace PomodoroTimer
{
    public partial class Form1 : Form 
    {
        System.Timers.Timer time;
        int hours, minute, second;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(Object sender, EventArgs e)
        {
            time = new System.Timers.Timer();
            time.Interval = 1000; // one second
            time.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                second += 1;
                if (second == 60)
                {
                    second = 0;
                    minute += 1;
                }

                if (minute == 60)
                {
                    minute = 0;
                    hours += 1;
                }

                timer.Text = string.Format("{0}:{1}:{2}", hours.ToString().PadLeft(2, '0'), minute.ToString().PadLeft(2, '0'), second.ToString().PadLeft(2, '0'));

            }));
        }

            private void start_Click(object sender, EventArgs e)
            {
            time.Start();
            }

        private void stop_Click_1(object sender, EventArgs e)
        {
            time.Stop();
            Application.DoEvents();
        }

    }
}
