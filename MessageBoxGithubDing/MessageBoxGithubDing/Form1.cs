using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxGithubDing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayMessage(string message)
        {
            MessageBox.Show(message);

        }

        private void btnMessageEenMaSt_Click(object sender, EventArgs e)
        {
            DisplayMessage("I want to play a game.");
        }

        private void btnMessageTweeMaSt_Click(object sender, EventArgs e)
        {
            DisplayMessage("Marco.....");
        }

        private void btnMessageDrieMaSt_Click(object sender, EventArgs e)
        {
            DisplayMessage("Polo");
        }
    }
}
