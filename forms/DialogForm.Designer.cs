using System.ComponentModel;
using Task_manager.entity;

namespace Task_manager.forms
{
    partial class DialogForm
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
        private void InitializeComponent(Action action)
        {
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 81);
            this.label1.TabIndex = 0;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(29, 110);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(73, 27);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "Так";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(130, 110);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(74, 27);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "Ні";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // ReturnDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.Name = "DialogForm";

            setText(action);
            
            this.ResumeLayout(false);
        }

        private void setText(Action action)
        {
            if (action == Action.ReturnToMainForm)
            {
                this.label1.Text = "Повернення до головної форме приведе до втрати змін. Бажаєте продовжити без збереження?";
                this.Text = "ReturnDialogForm";
            }
            else
            {
                this.label1.Text = "Видалити завдання? Повернути зміни буде неможливо";
                this.Text = "DeleteDialogForm";
            }
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;

        #endregion
    }
}