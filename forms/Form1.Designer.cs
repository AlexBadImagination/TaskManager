using System;
using System.Data;
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

        private DataTable dataTable;

        // Налаштуємо таблицю, де будуть відображатись завдання
        private void SetupDataGripView()
        {
            this.Controls.Add(tasksDataGrid);

            //Встановимо параметри таблиці даних
            //tasksDataGrid.ColumnCount = 5;
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
            /*this.tasksDataGrid.Columns[0].Name = "ID";
            this.tasksDataGrid.Columns[1].Name = "Назва";
            this.tasksDataGrid.Columns[2].Name = "Пріорітет";
            this.tasksDataGrid.Columns[3].Name = "Дедлайн";
            this.tasksDataGrid.Columns[4].Name = "Статус";*/
            
            dataTable = new DataTable();
            // Create new DataColumn, set DataType,
            // ColumnName and add to DataTable.
            
            DataColumn column;
            DataRow row;
            
            column = new DataColumn();
            column.DataType = System.Type.GetType(typeof(int).ToString());
            column.ColumnName = "ID";
            column.ReadOnly = true;
            //column.AutoIncrement = true;
            //column.Unique = true;
            // Add the Column to the DataColumnCollection.
            dataTable.Columns.Add(column);
            
            column = new DataColumn();
            column.DataType = System.Type.GetType(typeof(string).ToString());
            column.ColumnName = "Назва";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            dataTable.Columns.Add(column);
            
            column = new DataColumn();
            column.DataType = System.Type.GetType(typeof(int).ToString());
            column.ColumnName = "Пріорітет";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            dataTable.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType(typeof(DateTime).ToString());
            column.ColumnName = "Дедлайн";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            dataTable.Columns.Add(column);
            
            column = new DataColumn();
            column.DataType = System.Type.GetType(typeof(Status).ToString());
            column.ColumnName = "Статус";
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            dataTable.Columns.Add(column);
            

            
            // Make the ID column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = dataTable.Columns["ID"];
            dataTable.PrimaryKey = PrimaryKeyColumns;
            
            //Підв'яжемо данні про завданняя, що будуть відображатись у таблиці 
            foreach (Task task in Tasks)
            {
                row = dataTable.NewRow();
                row["ID"] = task.Id;
                row["Назва"] = task.Name;
                row["Пріорітет"] = task.Priority;
                row["Дедлайн"] = task.Deadline;
                row["Статус"] = task.Status;
                dataTable.Rows.Add(row);
            }
            
            tasksDataGrid.DataSource = dataTable;
            
            //Додаємо колонку з кнопками для редагування завдання
            DataGridViewButtonColumn buttonColumn = 
                new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "Редагувати завдання"; // Устанавливаем заголовок колонки с кнопками
            buttonColumn.Name = "";
            buttonColumn.Text = "Переглянути";
            buttonColumn.UseColumnTextForButtonValue = true;
            tasksDataGrid.Columns.Add(buttonColumn);
            
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