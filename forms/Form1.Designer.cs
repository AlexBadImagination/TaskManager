using System.Windows.Forms;
using Task_manager.entity;

namespace Task_manager.forms
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
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.tasksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(337, 315);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(150, 24);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Додати завдання";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskButtonClick);
            // 
            // showTaskButton
            // 
            this.showTaskButton.Location = new System.Drawing.Point(161, 315);
            this.showTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.showTaskButton.Name = "showTaskButton";
            this.showTaskButton.Size = new System.Drawing.Size(150, 25);
            this.showTaskButton.TabIndex = 1;
            this.showTaskButton.Text = "Редагувати";
            this.showTaskButton.UseVisualStyleBackColor = true;
            // 
            // tasksDataGrid
            // 
            this.tasksDataGrid.AllowUserToAddRows = false;
            this.tasksDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tasksDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tasksDataGrid.Location = new System.Drawing.Point(8, 37);
            this.tasksDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.tasksDataGrid.Name = "tasksDataGrid";
            this.tasksDataGrid.ReadOnly = true;
            this.tasksDataGrid.RowHeadersVisible = false;
            this.tasksDataGrid.Size = new System.Drawing.Size(500, 250);
            this.tasksDataGrid.TabIndex = 0;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(117, 12);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(87, 20);
            this.filterTextBox.TabIndex = 2;
            this.filterTextBox.TextChanged += new System.EventHandler(this.filterTextBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tasksDataGrid);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.showTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.tasksDataGrid)).EndInit();


            SetupDataGripView();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.TextBox filterTextBox;

        // Налаштуємо таблицю, де будуть відображатись завдання
        private void SetupDataGripView()
        {
            this.Controls.Add(tasksDataGrid);

            //Встановимо параметри таблиці даних
            tasksDataGrid.ColumnCount = 5;
            this.tasksDataGrid.Name = "tasksDataGrid";
            this.tasksDataGrid.Location = new System.Drawing.Point(8, 37);
            this.tasksDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.tasksDataGrid.Size = new System.Drawing.Size(500, 250);
            this.tasksDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.tasksDataGrid.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.tasksDataGrid.RowHeadersVisible = false;
            this.tasksDataGrid.TabIndex = 0;
            this.tasksDataGrid.ReadOnly = true;
            this.tasksDataGrid.AllowUserToAddRows = false;
            this.Controls.Add(tasksDataGrid);
            
            //Підпишемо колонки для виведення даних
            this.tasksDataGrid.Columns[0].Name = "ID";
            this.tasksDataGrid.Columns[1].Name = "Назва";
            this.tasksDataGrid.Columns[2].Name = "Пріорітет";
            this.tasksDataGrid.Columns[3].Name = "Дедлайн";
            this.tasksDataGrid.Columns[4].Name = "Статус";
            
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
                object[] row =
                {
                    task.Id, task.Name, task.Priority, task.Deadline, task.Status
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