using System.Data;
using System.Windows.Forms;
using Task_manager.entity;

namespace Task_manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTaskButton = new System.Windows.Forms.Button();
            this.showTaskButton = new System.Windows.Forms.Button();
            this.tasksDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.tasksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(341, 260);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(150, 24);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Додати завдання";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButtonClick);
            // 
            // editTaskButton
            // 
            this.showTaskButton.Location = new System.Drawing.Point(165, 260);
            this.showTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.showTaskButton.Name = "showTaskButton";
            this.showTaskButton.Size = new System.Drawing.Size(150, 25);
            this.showTaskButton.TabIndex = 1;
            this.showTaskButton.Text = "Редагувати";
            this.showTaskButton.UseVisualStyleBackColor = true;
            this.showTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // tasksDataGrid
            // 
            this.tasksDataGrid.Location = new System.Drawing.Point(0, 0);
            this.tasksDataGrid.Name = "tasksDataGrid";
            this.tasksDataGrid.Size = new System.Drawing.Size(265, 145);
            this.tasksDataGrid.TabIndex = 0;
            // 
            // Form1
            // this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            
            SetupDataGripView();
        }

        // Налаштуємо таблицю, де будуть відображатись завдання
        private void SetupDataGripView()
        {
            this.Controls.Add(tasksDataGrid);

            //Встановимо параметри таблиці даних
            tasksDataGrid.ColumnCount = 4;
            this.tasksDataGrid.Name = "tasksDataGrid";
            this.tasksDataGrid.Location = new System.Drawing.Point(8, 8);
            this.tasksDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.tasksDataGrid.Size = new System.Drawing.Size(500, 250);
            this.tasksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tasksDataGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tasksDataGrid.RowHeadersVisible = false;
            this.tasksDataGrid.TabIndex = 0;
            this.tasksDataGrid.ReadOnly = true;
            this.tasksDataGrid.AllowUserToAddRows = false;
            
            //Підпишемо колонки для виведення даних
            this.tasksDataGrid.Columns[0].Name = "Назва";
            this.tasksDataGrid.Columns[1].Name = "Пріорітет";
            this.tasksDataGrid.Columns[2].Name = "Дедлайн";
            this.tasksDataGrid.Columns[3].Name = "Статус";
            
            //Додаємо колонку з кнопками для редагування завдання
            DataGridViewButtonColumn buttonColumn = 
                new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "Редагувати завдання"; // Устанавливаем заголовок колонки с кнопками
            buttonColumn.Name = "Status Request";
            buttonColumn.Text = "Редагувати";
            buttonColumn.UseColumnTextForButtonValue = true;
            tasksDataGrid.Columns.Add(buttonColumn);
            
            //Підв'яжемо данні про завданняя, що будуть відображатись у таблиці 
            foreach (Task task in Tasks)
            {
                string[] row =
                {
                    task.Name, task.Priority.ToString(), task.Deadline.ToString(), task.Status.ToString()
                };
                this.tasksDataGrid.Rows.Add(row);
            }
            
            // Add a CellClick handler to handle clicks in the button column.
            tasksDataGrid.CellClick +=
                new DataGridViewCellEventHandler(dataGridView_CellClick);
        }

        private System.Windows.Forms.DataGridView tasksDataGrid;

        private System.Windows.Forms.Button showTaskButton;

        private System.Windows.Forms.Button addTaskButton;

        #endregion
    }
}