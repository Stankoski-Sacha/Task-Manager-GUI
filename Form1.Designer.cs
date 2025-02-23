namespace Task_Manager_GUI
{
    partial class TaskManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name = "disposing" > true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(2, 67);
            button1.Name = "button1";
            button1.Size = new Size(116, 66);
            button1.TabIndex = 0;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1AddTasks;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(4, 3);
            monthCalendar1.Location = new Point(364, -1);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += calendar1_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(317, 33);
            label1.TabIndex = 5;
            label1.Text = "Le Task Manager de la hess";
            label1.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(2, 151);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(2, 204);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(360, 256);
            checkedListBox1.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(124, 67);
            button2.Name = "button2";
            button2.Size = new Size(116, 66);
            button2.TabIndex = 8;
            button2.Text = "Clear Tasks";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2ClearTasks;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 180);
            label2.Name = "label2";
            label2.Size = new Size(221, 15);
            label2.TabIndex = 9;
            label2.Text = "Here are the tasks to complete for today ";
            // 
            // button3
            // 
            button3.Location = new Point(246, 67);
            button3.Name = "button3";
            button3.Size = new Size(116, 66);
            button3.TabIndex = 10;
            button3.Text = "Save/Load Tasks";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3SaveLoad;
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1285, 461);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(checkedListBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TaskManager";
            Text = "TaskManager";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private MonthCalendar monthCalendar1;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private Button button2;
        private Label label2;
        private Button button3;
    }
}
