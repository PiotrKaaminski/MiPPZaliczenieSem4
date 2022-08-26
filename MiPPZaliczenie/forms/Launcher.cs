using System;
using System.Windows.Forms;

namespace MiPPZaliczenie
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            MainForm newClient = new MainForm();
            newClient.Show();
        }
    }
}
