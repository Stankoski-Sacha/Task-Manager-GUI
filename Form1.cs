namespace Task_Manager_GUI
{
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Visible = true;
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.BalloonTipTitle = "Notification";
            notifyIcon.BalloonTipText = "Button clicked!";
            notifyIcon.ShowBalloonTip(3000);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = e.Start;
            //Code to show notification when date is changed
            //NotifyIcon notifyIcon = new NotifyIcon();
            //notifyIcon.Visible = true;
            //notifyIcon.Icon = SystemIcons.Information;
            //notifyIcon.BalloonTipTitle = "Notification";
            //notifyIcon.BalloonTipText = "Date changed!";
            //notifyIcon.ShowBalloonTip(3000);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }
    }
}
