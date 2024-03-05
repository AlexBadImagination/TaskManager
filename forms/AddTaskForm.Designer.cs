using System.ComponentModel;

namespace Task_manager
{
    partial class AddTaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.taskPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.taskStatusComboBox = new System.Windows.Forms.ComboBox();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.taskDeadlineTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.taskPriorityComboBox);
            this.panel1.Controls.Add(this.taskStatusComboBox);
            this.panel1.Controls.Add(this.addTaskButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.taskDeadlineTimeDatePicker);
            this.panel1.Controls.Add(this.taskDescriptionTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.taskNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 319);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(141, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Пріорітет завдання";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Статус завдання";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Переглянути всі завдання";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // taskPriorityComboBox
            // 
            this.taskPriorityComboBox.FormattingEnabled = true;
            this.taskPriorityComboBox.Items.AddRange(new object[] {1, 2, 3, 4, 5});
            this.taskPriorityComboBox.Location = new System.Drawing.Point(173, 215);
            this.taskPriorityComboBox.Name = "taskPriorityComboBox";
            this.taskPriorityComboBox.Size = new System.Drawing.Size(58, 21);
            this.taskPriorityComboBox.TabIndex = 8;
            this.taskPriorityComboBox.SelectedIndexChanged += new System.EventHandler(this.taskPriorityComboBox_SelectedIndexChanged);
            // 
            // taskStatusComboBox
            // 
            this.taskStatusComboBox.FormattingEnabled = true;
            this.taskStatusComboBox.Location = new System.Drawing.Point(17, 215);
            this.taskStatusComboBox.Name = "taskStatusComboBox";
            this.taskStatusComboBox.Size = new System.Drawing.Size(93, 21);
            this.taskStatusComboBox.TabIndex = 7;
            this.taskStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.taskStatusComboBox_SelectedIndexChanged);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(34, 262);
            this.addTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(76, 34);
            this.addTaskButton.TabIndex = 6;
            this.addTaskButton.Text = "Зберегти завдання";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введіть дедлайн завдання:";
            // 
            // taskDeadlineTimeDatePicker
            // 
            this.taskDeadlineTimeDatePicker.Location = new System.Drawing.Point(10, 154);
            this.taskDeadlineTimeDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.taskDeadlineTimeDatePicker.Name = "taskDeadlineTimeDatePicker";
            this.taskDeadlineTimeDatePicker.Size = new System.Drawing.Size(122, 20);
            this.taskDeadlineTimeDatePicker.TabIndex = 4;
            this.taskDeadlineTimeDatePicker.ValueChanged += new System.EventHandler(this.taskDeadlineTimeDatePicker_ValueChanged);
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(10, 93);
            this.taskDescriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(123, 20);
            this.taskDescriptionTextBox.TabIndex = 3;
            this.taskDescriptionTextBox.TextChanged += new System.EventHandler(this.taskDescriptionTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введіть опис завдання:";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.taskNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.taskNameTextBox.TabIndex = 1;
            this.taskNameTextBox.TextChanged += new System.EventHandler(this.taskNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть назву завдання:";
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTaskForm";
            this.Text = "Додати завдання";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ComboBox taskPriorityComboBox;

        private System.Windows.Forms.ComboBox taskStatusComboBox;

        private System.Windows.Forms.Button addTaskButton;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DateTimePicker taskDeadlineTimeDatePicker;

        private System.Windows.Forms.TextBox taskDescriptionTextBox;

        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}