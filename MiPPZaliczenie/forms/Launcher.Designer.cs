
namespace MiPPZaliczenie
{
    partial class Launcher
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
            this.LaunchButton = new System.Windows.Forms.Button();
            this.LauncherLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LaunchButton.ForeColor = System.Drawing.Color.Black;
            this.LaunchButton.Location = new System.Drawing.Point(40, 146);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(187, 81);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Uruchom";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // LauncherLabel
            // 
            this.LauncherLabel.AutoSize = true;
            this.LauncherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LauncherLabel.ForeColor = System.Drawing.Color.White;
            this.LauncherLabel.Location = new System.Drawing.Point(64, 22);
            this.LauncherLabel.Name = "LauncherLabel";
            this.LauncherLabel.Size = new System.Drawing.Size(148, 31);
            this.LauncherLabel.TabIndex = 1;
            this.LauncherLabel.Text = "Messenger\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autor: Piotr Kamiński\r\nGrupa: Z407";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(260, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LauncherLabel);
            this.Controls.Add(this.LaunchButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger Launcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Label LauncherLabel;
        private System.Windows.Forms.Label label1;
    }
}

