﻿using System;
using System.Linq;
using System.Windows.Forms;
using Task_manager.entity;

namespace Task_manager
{
    public partial class AddTask : Form
    {
        private string Name;
        private string Description;
        private DateTime Deadline;
        private Status Status;
        private Form1 Form1;
        
        public AddTask(Form1 form1)
        {
            InitializeComponent();
            Form1 = form1;
            
            Array valArray = typeof(Status).GetEnumValues();

            foreach (object obj in valArray)
            {
                taskStatusListBox.Items.Add(obj);
            }
        }

        private void taskNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Name = taskNameTextBox.Text;
        }

        private void taskDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            Description = taskDescriptionTextBox.Text;
        }

        private void taskDeadlineTimeDatePicker_ValueChanged(object sender, EventArgs e)
        {
            Deadline = taskDeadlineTimeDatePicker.Value;
        }

        private void taskStatusListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status = (Status)taskStatusListBox.SelectedItem;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            Task task = new Task(Name, Description, Deadline, Status);
            Form1.Tasks.Add(task);
            this.Close();
        }
    }
}