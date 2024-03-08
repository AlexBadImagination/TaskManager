using System;
using System.Windows.Forms;
using Task_manager.entity;
using Action = Task_manager.entity.Action;

namespace Task_manager.forms
{
    public partial class AddTaskForm : Form
    {
        private readonly Task _task;
        private readonly Form1 _form1;
        
        public AddTaskForm(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            _task = new Task();
            
            Array valArray = typeof(Status).GetEnumValues();

            foreach (object obj in valArray)
            {
                taskStatusComboBox.Items.Add(obj);
            }
        }

        private void taskNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _task.Name = taskNameTextBox.Text;
        }

        private void taskDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _task.Description = taskDescriptionTextBox.Text;
        }

        private void taskDeadlineDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _task.Deadline = taskDeadlineDatePicker.Value;
        }

        /*private void taskDeadlineTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _task.Deadline = taskDeadlineTimePicker.Value;
        }*/

        private void taskStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _task.Status = (Status)taskStatusComboBox.SelectedItem;
        }

        private void taskPriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _task.Priority = (int)taskPriorityComboBox.SelectedItem;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            _form1.Tasks.Add(_task);
            Console.Out.WriteLine(_form1.Tasks.Count);
            _form1.DisplayTasks();
            this.Close();
        }

        private void showAllTasksButton_Click(object sender, EventArgs e)
        {
            DialogForm dialog = new DialogForm(Action.ReturnToMainForm);
            DialogResult dr = dialog.ShowDialog(this);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}