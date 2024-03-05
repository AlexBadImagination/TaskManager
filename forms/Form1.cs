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
            Tasks = new List<Task>();
            
            Tasks.Add(new Task("Зробити практичну", "Написати програму", new DateTime(2024, 3, 5), Status.Заплановано, 5));
            InitializeComponent();
        }

        private void addTaskButtonClick(object sender, EventArgs e)
        {
            AddTaskForm newForm = new AddTaskForm(this);
            newForm.Show();
        }

        private void editTaskButton_Click(object sender, EventArgs e)
        {
            ShowTaskForm newForm = new ShowTaskForm(this);
            newForm.Show();
            
        }

        public void DisplayTasks()
        {
            tasksDataGrid.Rows.Clear();
            foreach (Task task in Tasks)
            {
                string[] row =
                {
                    task.Name, task.Priority.ToString(), task.Deadline.ToString(), task.Status.ToString()
                };
                tasksDataGrid.Rows.Add(row);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex !=
                tasksDataGrid.Columns["Status Request"].Index) return;

            // Retrieve the task ID.
            Int32 taskID = (Int32)tasksDataGrid[0, e.RowIndex].Value;

            // Retrieve the Employee object from the "Assigned To" cell.
            /*Employee assignedTo = tasksDataGrid.Rows[e.RowIndex]
                .Cells["Assigned To"].Value as Employee;
            

            // Request status through the Employee object if present. 
            if (assignedTo != null)
            {
                assignedTo.RequestStatus(taskID);
            }
            else
            {
                MessageBox.Show(String.Format(
                    "Task {0} is unassigned.", taskID), "Status Request");
            }*/
        }
    }
}