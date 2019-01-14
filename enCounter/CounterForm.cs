using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace enCounter
{
    public partial class CounterForm : Form
    {

    
        private const string InitialTimerText = "Time Spent: 0:00";
        private const string InitialCounterText = "Current Encounter: 0";

        private ConnectionSettingsForm connSettings = new ConnectionSettingsForm();
      

        private bool state;

        private Stopwatch stopwatch = new Stopwatch();

        public CounterForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.init();
        }


        private void init()
        {
            // add our tick event handler
            updateTimer.Tick += (object sender, EventArgs e) =>
            {
                TimeSpan ts = stopwatch.Elapsed;
                timeSpent.Text = "Time Spent: " + String.Format("{0}:{1:00}", ts.Minutes, ts.Seconds);                
            };

         
        }

        private void CounterForm_Load(object sender, EventArgs e)
        {
        }

        private void toggleButton_Click(object sender, EventArgs e)
        {
            if (state)
            {
                state = false;
                updateTimer.Stop();

                toggleButton.Text = "Start";
                currentCounter.Text = "Current Encounter: 0";
                timeSpent.Text = "Time Spent: 0:00";

                stopwatch.Stop();
                stopwatch.Reset();
               

            } else
            {
                state = true;
                updateTimer.Start();

                stopwatch.Start();

                toggleButton.Text = "Stop";
            }
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connSettings.ShowDialog();
        }
    }
}
