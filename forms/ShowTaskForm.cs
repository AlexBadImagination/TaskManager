using System;
using System.Windows.Forms;
using Task_manager.entity;
using Action = Task_manager.entity.Action;
using Task = Task_manager.entity.Task;

namespace Task_manager.forms
{
    public partial class ShowTaskForm : Form
    {
        private readonly Task _task;
        private readonly Form1 _form1;
        public ShowTaskForm(Form1 form1, Task task)
        {
            InitializeComponent();
            _form1 = form1;
            _task = task;
            
            Array valArray = typeof(Status).GetEnumValues();

            foreach (object obj in valArray)
            {
                statusComboBox.Items.Add(obj);
            }

            FillFormWithTaskData(task);
        }

        private void FillFormWithTaskData(Task task)
        {
            nameTextBox.Text = task.Name;
            descriptionTextBox.Text = task.Description;
            deadlineTimeDatePicker.Value = task.Deadline;
            statusComboBox.SelectedItem = task.Status;
            priorityComboBox.SelectedItem = task.Priority;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            _task.Name = nameTextBox.Text;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _task.Description = descriptionTextBox.Text;
        }

        private void deadlineTimeDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _task.Deadline = deadlineTimeDatePicker.Value;
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _task.Status = (Status) statusComboBox.SelectedItem;
        }

        private void priorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _task.Priority = (int) priorityComboBox.SelectedItem;
        }
        
        private void editTaskButton_Click(object sender, EventArgs e)
        {
            int taskIndex = _form1.Tasks.IndexOf( 
                _form1.Tasks.Find(task => task.Id == _task.Id)
                );
            _form1.Tasks[taskIndex] = _task;
            _form1.DisplayTasks();
            this.Close();
        }

        private void deleteTaskButton_Click(object sender, EventArgs e)
        {
            DialogForm dialog = new DialogForm(Action.Delete);
            DialogResult dr = dialog.ShowDialog(this);
            if (dr == DialogResult.Yes)
            {
                _form1.Tasks.Remove(_form1.Tasks.Find(task => task.Id == _task.Id));
                _form1.DisplayTasks();
                this.Close();
            }
            return;
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