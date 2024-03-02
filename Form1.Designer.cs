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
            this.SuspendLayout();
            // 
            // addTaskButton
            // 
            this.addTaskButton.Location = new System.Drawing.Point(455, 320);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(200, 30);
            this.addTaskButton.TabIndex = 0;
            this.addTaskButton.Text = "Додати завдання";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButtonClick);
            // 
            // showTaskButton
            // 
            this.showTaskButton.Location = new System.Drawing.Point(276, 321);
            this.showTaskButton.Name = "showTaskButton";
            this.showTaskButton.Size = new System.Drawing.Size(144, 29);
            this.showTaskButton.TabIndex = 1;
            this.showTaskButton.Text = "Показати завдання";
            this.showTaskButton.UseVisualStyleBackColor = true;
            this.showTaskButton.Click += new System.EventHandler(this.showTaskButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showTaskButton);
            this.Controls.Add(this.addTaskButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button showTaskButton;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Button addTaskButton;

        #endregion
    }
}