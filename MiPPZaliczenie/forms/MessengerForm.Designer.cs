
namespace MiPPZaliczenie.forms
{
    partial class MessengerForm
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
            this.MessageInputTextBox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.MessagesOutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MessageInputTextBox
            // 
            this.MessageInputTextBox.Location = new System.Drawing.Point(1, 374);
            this.MessageInputTextBox.Multiline = true;
            this.MessageInputTextBox.Name = "MessageInputTextBox";
            this.MessageInputTextBox.Size = new System.Drawing.Size(700, 75);
            this.MessageInputTextBox.TabIndex = 0;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(700, 374);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(100, 75);
            this.SendMessageButton.TabIndex = 1;
            this.SendMessageButton.Text = "button1";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // MessagesOutputTextBox
            // 
            this.MessagesOutputTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MessagesOutputTextBox.Location = new System.Drawing.Point(0, 0);
            this.MessagesOutputTextBox.Multiline = true;
            this.MessagesOutputTextBox.Name = "MessagesOutputTextBox";
            this.MessagesOutputTextBox.ReadOnly = true;
            this.MessagesOutputTextBox.Size = new System.Drawing.Size(800, 378);
            this.MessagesOutputTextBox.TabIndex = 2;
            // 
            // MessengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessagesOutputTextBox);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.MessageInputTextBox);
            this.Name = "MessengerForm";
            this.Text = "MessengerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MessageInputTextBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.TextBox MessagesOutputTextBox;
    }
}