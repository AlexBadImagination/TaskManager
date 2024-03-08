using System.ComponentModel;

namespace Task_manager.forms
{
    partial class ShowTaskForm
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
            this.showAllTasksButton = new System.Windows.Forms.Button();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.deadlineTimeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.showAllTasksButton);
            this.panel1.Controls.Add(this.deleteTaskButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.priorityComboBox);
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.editTaskButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.deadlineTimeDatePicker);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(48, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 319);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(178, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пріорітет завдання";
            // 
            // showAllTasksButton
            // 
            this.showAllTasksButton.Location = new System.Drawing.Point(245, 262);
            this.showAllTasksButton.Margin = new System.Windows.Forms.Padding(2);
            this.showAllTasksButton.Name = "showAllTasksButton";
            this.showAllTasksButton.Size = new System.Drawing.Size(76, 34);
            this.showAllTasksButton.TabIndex = 11;
            this.showAllTasksButton.Text = "Переглянути всі задвання";
            this.showAllTasksButton.UseVisualStyleBackColor = true;
            this.showAllTasksButton.Click += new System.EventHandler(this.showAllTasksButton_Click);
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Location = new System.Drawing.Point(134, 262);
            this.deleteTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(76, 34);
            this.deleteTaskButton.TabIndex = 10;
            this.deleteTaskButton.Text = "Видалити завдання";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус завдання";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Items.AddRange(new object[] {1, 2, 3, 4, 5});
            this.priorityComboBox.Location = new System.Drawing.Point(203, 216);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(58, 21);
            this.priorityComboBox.TabIndex = 8;
            this.priorityComboBox.SelectedIndexChanged += new System.EventHandler(this.priorityComboBox_SelectedIndexChanged);
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(10, 216);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(93, 21);
            this.statusComboBox.TabIndex = 7;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Location = new System.Drawing.Point(34, 262);
            this.editTaskButton.Margin = new System.Windows.Forms.Padding(2);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(76, 34);
            this.editTaskButton.TabIndex = 6;
            this.editTaskButton.Text = "Зберегти зміни";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дедлайн завдання\r\n";
            // 
            // deadlineTimeDatePicker
            // 
            this.deadlineTimeDatePicker.Location = new System.Drawing.Point(10, 154);
            this.deadlineTimeDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.deadlineTimeDatePicker.Name = "deadlineTimeDatePicker";
            this.deadlineTimeDatePicker.Size = new System.Drawing.Size(122, 20);
            this.deadlineTimeDatePicker.TabIndex = 4;
            this.deadlineTimeDatePicker.ValueChanged += new System.EventHandler(this.deadlineTimeDatePicker_ValueChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 93);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(123, 20);
            this.descriptionTextBox.TabIndex = 3;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Опис завдання";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(9, 32);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(126, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва завдання";
            // 
            // ShowTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ShowTaskForm";
            this.Text = "Завдання";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.Button showAllTasksButton;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker deadlineTimeDatePicker;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}