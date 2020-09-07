using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;

namespace WebBrowser.UI
{
    public partial class NewTabUserControl : UserControl
    {
        Stack<string> backLinks = new Stack<string>();
        Stack<string> forwardLinks = new Stack<string>();
        public NewTabUserControl()
        {
            InitializeComponent();
        }

        //Tool Strip 

        //Back Button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            
            forwardLinks.Push(txtBoxAddressbar.Text);

            String url = txtBoxAddressbar.Text;
            backLinks.Push(url);
            webBrowser1.Navigate(url);

            
        }

        //Forward Button
        private void btnForward_Click(object sender, EventArgs e)
        {
            foreach (var item in forwardLinks)
            {
                backLinks.Push(txtBoxAddressbar.Text);

                string url = txtBoxAddressbar.Text;
                forwardLinks.Pop()
                webBrowser1.Navigate(url);
            }
        }

        //Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
        //Home Button

        //Address Bar
        private void txtBoxAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string url = txtBoxAddressbar.Text;

                if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
                {
                    txtBoxAddressbar.Text = url;
                    webBrowser1.Navigate(url);
                    webBrowser1.ScriptErrorsSuppressed = true;
                }
            }
        }
        //Go Button
        private void btnGo_Click_1(object sender, EventArgs e)
        {
            string url = txtBoxAddressbar.Text;
            webBrowser1.Navigate(url);
        }

        //Backlinks Field 
        public void addBackLink()
        {
            string url = txtBoxAddressbar.Text;
            backLinks.Push(url);
        }


       //ForwardLinks Field
        public void addForwardLink()
        {
            if(txtBoxAddressbar.Text != null)
            {

                forwardLinks.Push(txtBoxAddressbar.Text);
            }

        }
        
       
       
    }
}
