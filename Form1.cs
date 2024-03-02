using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Task_manager.entity;

namespace Task_manager
{
    public partial class Form1 : Form
    {
        public List<Task> Tasks { get; set; }
        public Form1()
        {
            InitializeComponent();
            Tasks = new List<Task>();
        }

        private void addTaskButtonClick(object sender, EventArgs e)
        {
            AddTask newForm = new AddTask(this);
            newForm.Show();
        }


        private void showTaskButton_Click(object sender, EventArgs e)
        {
            Task task = Tasks.Last();
            Console.Out.WriteLine(task.Name);
            Console.Out.WriteLine(task.Description);
            Console.Out.WriteLine(task.Deadline);
            Console.Out.WriteLine(task.Status);
        }
    }
}