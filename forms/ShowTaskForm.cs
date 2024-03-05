using System;
using System.Windows.Forms;
using Task_manager.entity;

namespace Task_manager
{
    public partial class ShowTaskForm : Form
    {
        private Form1 Form1;
        public ShowTaskForm(Form1 form1)
        {
            InitializeComponent();
            Form1 = form1;
        }

        private void addTaskButton_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}