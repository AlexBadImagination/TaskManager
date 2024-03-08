using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Task_manager.entity;
using Task = Task_manager.entity.Task;

namespace Task_manager.forms
{
    public partial class Form1 : Form
    {
        public List<Task> Tasks { get; set; }
        public Form1()
        {
            Tasks = new List<Task> {new Task("Зробити практичну", "Написати програму", new DateTime(2024, 3, 5), Status.Заплановано, 5)};

            InitializeComponent();
        }

        private void AddTaskButtonClick(object sender, EventArgs e)
        {
            AddTaskForm newForm = new AddTaskForm(this);
            newForm.Show();
        }

        private void EditTask(Task task)
        {
            ShowTaskForm newForm = new ShowTaskForm(this, task);
            newForm.Show();
        }

        public void DisplayTasks()
        {
            dataTable.Clear();
            foreach (Task task in Tasks)
            {
                DataRow row;
                row = dataTable.NewRow();
                row["ID"] = task.Id;
                row["Назва"] = task.Name;
                row["Пріорітет"] = task.Priority;
                row["Дедлайн"] = task.Deadline;
                row["Статус"] = task.Status;
                dataTable.Rows.Add(row);
            }
            tasksDataGrid.DataSource = dataTable;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks that are not on button cells. 
            if (e.RowIndex < 0 || e.ColumnIndex != tasksDataGrid.Columns[""].Index) return;

            // Retrieve the task ID.
            // Вывести в таблицу ID, чтобы брать его и искать
            /*Int32 taskId = (Int32)tasksDataGrid.DataSource[0, e.RowIndex].Value;

            // Retrieve the Employee object from the "Assigned To" cell.
            Task task = Tasks.Find(tempTask => tempTask.Id == taskId);
            

            // Request status through the Employee object if present. 
            if (task != null)
            {
                EditTask(task);
            }
            else
            {
                MessageBox.Show("Немає завдання з таким ID", "Неправильне ID");
            }*/
        }
        
        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            ((DataTable) tasksDataGrid.DataSource).DefaultView.RowFilter =
                String.Format("Name like '{0}%'", filterTextBox.Text);
            //DisplayTasks();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
    }
}