using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hannah Friedman, hzf0023" + "\n" + 
                "This is my very first web browser as well as my first large project with c#" +
                "\n" + "I am very excited about creating this and cant wait to explore more of Win. Forms!");

        }

        private void txtBoxAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = txtBoxAddress.Text;

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    tabPage1.Text = url;
                    webBrowser1.Navigate(url);
                }
            }
        }
    

    private void btnGo_Click(object sender, EventArgs e)
    {
        string url = txtBoxAddress.Text;

        if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
        {
            tabPage1.Text = url;
            webBrowser1.Navigate(url);
        }
    }
}
}

