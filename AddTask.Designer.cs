using System.ComponentModel;

namespace Task_manager
{
    partial class AddTask
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
            this.taskStatusListBox = new System.Windows.Forms.ListBox();
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
            this.panel1.Controls.Add(this.taskStatusListBox);
            this.panel1.Controls.Add(this.addTaskButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.taskDeadlineTimeDatePicker);
            this.panel1.Controls.Add(this.taskDescriptionTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.taskNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 390);
            this.panel1.TabIndex = 0;
            // 
            // taskStatusListBox
            // 
            this.taskStatusListBox.FormattingEnabled = true;
            this.taskStatusListBox.ItemHeight = 16;
            this.taskStatusListBox.Location = new System.Drawing.Point(24, 236);
            this.taskStatusListBox.Name = "taskStatusListBox";
            this.taskStatusListBox.Size = new System.Drawing.Size(123, 68);
            this.taskStatusListBox.TabIndex = 7;
            this.taskStatusListBox.SelectedIndexChanged += new System.EventHandler(this.taskStatusListBox_SelectedIndexChanged);
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(45, 323);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(102, 42);
            this.addTaskButton.TabIndex = 6;
            this.addTaskButton.Text = "Зберегти завдання";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введіть дедлайн завдання:";
            // 
            // taskDeadlineTimeDatePicker
            // 
            this.taskDeadlineTimeDatePicker.Location = new System.Drawing.Point(14, 190);
            this.taskDeadlineTimeDatePicker.Name = "taskDeadlineTimeDatePicker";
            this.taskDeadlineTimeDatePicker.Size = new System.Drawing.Size(162, 22);
            this.taskDeadlineTimeDatePicker.TabIndex = 4;
            this.taskDeadlineTimeDatePicker.ValueChanged += new System.EventHandler(this.taskDeadlineTimeDatePicker_ValueChanged);
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(14, 114);
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(163, 22);
            this.taskDescriptionTextBox.TabIndex = 3;
            this.taskDescriptionTextBox.TextChanged += new System.EventHandler(this.taskDescriptionTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введіть опис завдання:";
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Location = new System.Drawing.Point(12, 39);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(166, 22);
            this.taskNameTextBox.TabIndex = 1;
            this.taskNameTextBox.TextChanged += new System.EventHandler(this.taskNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть назву завдання:";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddTask";
            this.Text = "AddTask";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox taskStatusListBox;

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