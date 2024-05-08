using System.Drawing.Text;
using System.Timers;

namespace MiniProject_1
{
    public partial class Form1 : Form
    {
        public string time;
        System.Timers.Timer timer;
        int h, m, s;
        double ms;

        string totalTime, startTime, stopTime;
        public Form1()
        {
            InitializeComponent();

        }

        private void tmrStr_Click(object sender, EventArgs e)
        {
            tmrStp.Visible = true;
            tmrStr.Visible = false;
            EntData.Visible = false;
            startTime = DateTime.Now.ToString("dd/MM/yy h:mm:ss tt");

            timer.Start();
        }

        private void tmrStp_Click(object sender, EventArgs e)
        {
            tmrStr.Visible = true;
            tmrStp.Visible = false;
            EntData.Visible = true;
            stopTime = DateTime.Now.ToString("dd/MM/yy h:mm:ss tt");

            timer.Stop();
        }

        private void EntData_Click(object sender, EventArgs e)
        {
            time = label1.Text.ToString();

            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            label1.Text = "00:00:00.000";

            Form2 f2 = new(startTime, stopTime);
            f2.Show();

            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                ms += 1.5;


                if (ms > 100)
                {
                    ms = 0;
                    s += 1;
                }

                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }

                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                int mms = (int)(ms * 10);
                label1.Text = string.Format("{0}:{1}:{2}.{3}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'), mms.ToString().PadLeft(3, '0'));

            }));
        }

        void uploadTime()
        {
            string stoptime = time;
        }

    }
}