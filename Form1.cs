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
            string task = showTaskPrompt();
            if (!string.IsNullOrEmpty(task))
            {
                checkedListBox1.Items.Add(task);
                MessageBox.Show("Task Added Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Task cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conf = clearTasks().Trim().ToLower();
            if (conf == "yes")
            {
                checkedListBox1.Items.Clear();
                MessageBox.Show("Tasks Cleared Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tasks not cleared", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = e.Start;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.SetDate(dateTimePicker1.Value);
        }

        private string showTaskPrompt()
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = "Enter Task";
            prompt.ShowDialog();
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            Label textLabel1 = new Label() { Left = 50, Top = 20, Text = "Enter Task" };
            TextBox textBox1 = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Add", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.DialogResult = DialogResult.OK;

            prompt.Controls.Add(textLabel1);
            prompt.Controls.Add(textBox1);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox1.Text : "";
        }

        private string clearTasks()
        {
            Form prompt = new Form();
            prompt.Width = 500;
            prompt.Height = 150;
            prompt.Text = "Clear Tasks";
            prompt.ShowDialog();
            prompt.MinimizeBox = false;
            prompt.MaximizeBox = false;
            prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
            prompt.StartPosition = FormStartPosition.CenterScreen;

            Label text1 = new Label() { Left = 50, Top = 20, Text = "Are you sure you want to clear all tasks? Type yes to confirm" };
            TextBox conf = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Clear", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.DialogResult = DialogResult.OK;

            prompt.Controls.Add(text1);
            prompt.Controls.Add(conf);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? conf.Text : "";
        }
    }
}




//Code to show notification when date is changed
//NotifyIcon notifyIcon = new NotifyIcon();
//notifyIcon.Visible = true;
//notifyIcon.Icon = SystemIcons.Information;
//notifyIcon.BalloonTipTitle = "Notification";
//notifyIcon.BalloonTipText = "Date changed!";
//notifyIcon.ShowBalloonTip(3000);