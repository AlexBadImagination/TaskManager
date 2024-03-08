using System;
using System.Windows.Forms;
using Action = Task_manager.entity.Action;

namespace Task_manager.forms
{
    public partial class DialogForm : Form
    {
        public DialogForm(Action action)
        {
            InitializeComponent(action);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}