using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MiPPZaliczenie.forms;
using MiPPZaliczenie.services;

namespace MiPPZaliczenie
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService = UserService.getInstance();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_MouseEnter(object sender, EventArgs e)
        {
            UsernameValidationInfoLabel.Visible = true;
        }

        private void UsernameTextBox_MouseLeave(object sender, EventArgs e)
        {
            UsernameValidationInfoLabel.Visible = false;
        }

        private void PasswordTextBox_MouseEnter(object sender, EventArgs e)
        {
            PasswordValidationInfoLabel.Visible = true;
        }

        private void PasswordTextBox_MouseLeave(object sender, EventArgs e)
        {
            PasswordValidationInfoLabel.Visible = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool success = _userService.RegisterUser(UsernameTextBox.Text, PasswordTextBox.Text);
            if (success)
            {
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
            else
            {
                InputError();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Users user = _userService.Login(UsernameTextBox.Text, PasswordTextBox.Text);
            if (user == null)
            {
                InputError();
                return;
            }
            Hide();
            MessengerForm messengerForm = new MessengerForm(user);
            messengerForm.Show();
        }

        private void InputError()
        {
            UsernameTextBox.BackColor = Color.LightPink;
            PasswordTextBox.BackColor = Color.LightPink;
        }
    }
}
