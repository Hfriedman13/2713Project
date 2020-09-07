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

        //Menu Items
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

        private void newTabMenuItem_Click(object sender, EventArgs e)
        {
 
                string title = "TabPage " + (tabPage.TabCount + 1).ToString();
                TabPage myTabPage = new TabPage(title);
                tabPage.TabPages.Add(myTabPage);

                myTabPage.Controls.Add(new NewTabUserControl());
                NewTabUserControl.Instance.Dock = DockStyle.Fill;
                NewTabUserControl.Instance.BringToFront();
        }
    

        private void closeCurrentTabMenuItem_Click(object sender, EventArgs e)
        {
            // Removes the selected tab:  
            tabPage.TabPages.Remove(tabPage.SelectedTab); 
        }

    }
}

