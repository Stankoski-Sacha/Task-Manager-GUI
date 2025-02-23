using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics.Eventing.Reader;

namespace Task_Manager_GUI
{
    public partial class TaskManager : Form
    {
        private Dictionary<DateTime, List<String>> tasksByDay = new Dictionary<DateTime, List<String>>();
        public TaskManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1AddTasks(object sender, EventArgs e)
        {
            string task = Microsoft.VisualBasic.Interaction.InputBox("Enter Task", "Task Manager", "");
            if (!string.IsNullOrEmpty(task))
            {
                DateTime current = dateTimePicker1.Value.Date;

                if (!tasksByDay.ContainsKey(current))
                {
                    tasksByDay[current] = new List<string>();
                }
                tasksByDay[current].Add(task);
                UpdateTaskList(current);
                MessageBox.Show("Task Added Succefully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Task cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2ClearTasks(object sender, EventArgs e)
        {
            string conf = Microsoft.VisualBasic.Interaction.InputBox("Clear Tasks ? Type yes to confirm", "Task Manager", "").Trim().ToLower();
            if (conf == "yes")
            {
                checkedListBox1.Items.Clear();
                tasksByDay.Clear();
                MessageBox.Show("Tasks Cleared Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tasks not cleared", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3SaveLoad(object sender, EventArgs e)
        {
            string choice = Microsoft.VisualBasic.Interaction.InputBox("Enter 'save' to save tasks or 'load' to load tasks", "Task Manager", "").Trim().ToLower();
            if (choice == "save")
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Json|*.json";
                saveFileDialog1.Title = "Save Tasks";
                saveFileDialog1.ShowDialog();
                string json = JsonSerializer.Serialize(tasksByDay);
                File.WriteAllText(saveFileDialog1.FileName, json);
                MessageBox.Show("Tasks Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (choice == "load")
            {
                string conf = Microsoft.VisualBasic.Interaction.InputBox("Load Tasks ? Be awa&re it will delete the current tasks, type 'yes to confirm'", "Task Manager", "").Trim().ToLower();
                if (conf == "yes")
                {
                    OpenFileDialog openFileDialog1 = new OpenFileDialog();
                    openFileDialog1.Filter = "Json|*.json";
                    openFileDialog1.Title = "Load Tasks";
                    openFileDialog1.ShowDialog();
                    string json = File.ReadAllText(openFileDialog1.FileName);
                    tasksByDay.Clear();
                    tasksByDay = JsonSerializer.Deserialize<Dictionary<DateTime, List<String>>>(json);
                    UpdateTaskList(dateTimePicker1.Value.Date);
                    MessageBox.Show("Tasks Loaded Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tasks not loaded", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid choice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateTaskList(DateTime selectedDate)
        {
            checkedListBox1.Items.Clear(); // Clear previous items

            if (tasksByDay.ContainsKey(selectedDate))
            {
                foreach (string task in tasksByDay[selectedDate])
                {
                    checkedListBox1.Items.Add(task, false); // Add task (unchecked)
                }
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
    }
}

//Code to show notification when date is changed
//NotifyIcon notifyIcon = new NotifyIcon();
//notifyIcon.Visible = true;
//notifyIcon.Icon = SystemIcons.Information;
//notifyIcon.BalloonTipTitle = "Notification";
//notifyIcon.BalloonTipText = "Date changed!";
//notifyIcon.ShowBalloonTip(3000);