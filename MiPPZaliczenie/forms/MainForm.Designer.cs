
namespace MiPPZaliczenie
{
    partial class MainForm
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
            this.PasswordValidationInfoLabel = new System.Windows.Forms.Label();
            this.UsernameValidationInfoLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordValidationInfoLabel
            // 
            this.PasswordValidationInfoLabel.AutoSize = true;
            this.PasswordValidationInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PasswordValidationInfoLabel.Location = new System.Drawing.Point(228, 144);
            this.PasswordValidationInfoLabel.Name = "PasswordValidationInfoLabel";
            this.PasswordValidationInfoLabel.Size = new System.Drawing.Size(227, 52);
            this.PasswordValidationInfoLabel.TabIndex = 24;
            this.PasswordValidationInfoLabel.Text = "Minimalna długość: 5\r\nMaksymalna długość: 30\r\nWymagane znaki: mały znak, duży zna" +
    "k, cyfra\r\nBiałe znaki niedozwolone";
            this.PasswordValidationInfoLabel.Visible = false;
            // 
            // UsernameValidationInfoLabel
            // 
            this.UsernameValidationInfoLabel.AutoSize = true;
            this.UsernameValidationInfoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UsernameValidationInfoLabel.Location = new System.Drawing.Point(266, 43);
            this.UsernameValidationInfoLabel.Name = "UsernameValidationInfoLabel";
            this.UsernameValidationInfoLabel.Size = new System.Drawing.Size(189, 52);
            this.UsernameValidationInfoLabel.TabIndex = 23;
            this.UsernameValidationInfoLabel.Text = "Nazwa uzytkownika musi być unikalna\r\nMinimalna długość: 5\r\nMaksymalna długość: 30" +
    "\r\nBiałe znaki niedozwolone";
            this.UsernameValidationInfoLabel.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.White;
            this.PasswordLabel.Location = new System.Drawing.Point(109, 183);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(36, 13);
            this.PasswordLabel.TabIndex = 22;
            this.PasswordLabel.Text = "Hasło";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(109, 82);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(102, 13);
            this.UsernameLabel.TabIndex = 21;
            this.UsernameLabel.Text = "Nazwa użytkownika";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(112, 199);
            this.PasswordTextBox.MaxLength = 30;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(343, 20);
            this.PasswordTextBox.TabIndex = 20;
            this.PasswordTextBox.WordWrap = false;
            this.PasswordTextBox.MouseEnter += new System.EventHandler(this.PasswordTextBox_MouseEnter);
            this.PasswordTextBox.MouseLeave += new System.EventHandler(this.PasswordTextBox_MouseLeave);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(112, 98);
            this.UsernameTextBox.MaxLength = 30;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(343, 20);
            this.UsernameTextBox.TabIndex = 19;
            this.UsernameTextBox.WordWrap = false;
            this.UsernameTextBox.MouseEnter += new System.EventHandler(this.UsernameTextBox_MouseEnter);
            this.UsernameTextBox.MouseLeave += new System.EventHandler(this.UsernameTextBox_MouseLeave);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RegisterButton.ForeColor = System.Drawing.Color.Black;
            this.RegisterButton.Location = new System.Drawing.Point(320, 310);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(187, 81);
            this.RegisterButton.TabIndex = 18;
            this.RegisterButton.Text = "Zarejestruj się";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(79, 310);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(187, 81);
            this.LoginButton.TabIndex = 17;
            this.LoginButton.Text = "Zaloguj się";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(586, 435);
            this.Controls.Add(this.PasswordValidationInfoLabel);
            this.Controls.Add(this.UsernameValidationInfoLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordValidationInfoLabel;
        private System.Windows.Forms.Label UsernameValidationInfoLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button LoginButton;
    }
}