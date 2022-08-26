using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiPPZaliczenie.services;

namespace MiPPZaliczenie.forms
{
    public partial class MessengerForm : Form
    {
        private readonly Users _currentUser;
        private MessageService messageService;

        public MessengerForm(Users currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            Text = currentUser.username;
            messageService = MessageService.getInstance();
            messageService.messageSent += receiveMessage;
        }

        private void receiveMessage(model.Message message)
        {
            MessagesOutputTextBox.Text += $"{message.messageDate} {message.author.username}\r\n";
            MessagesOutputTextBox.Text += $"{message.content}\r\n\r\n";
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            string content = MessageInputTextBox.Text;
            if (string.IsNullOrWhiteSpace(content))
            {
                return;
            }

            model.Message message = new model.Message();

            message.author = _currentUser;
            message.messageDate = DateTime.Now;
            message.content = content;
            messageService.sendMessage(message);
            MessageInputTextBox.Text = "";
        }
    }
}
