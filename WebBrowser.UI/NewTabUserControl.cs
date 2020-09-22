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
using WebBrowser.Logic;
using WebBrowser.UI.BrowserDatabaseDataSetTableAdapters;
using System.Reflection;

namespace WebBrowser.UI
{
    public partial class NewTabUserControl : UserControl
    {
        Stack<string> backLinks = new Stack<string>();
        Stack<string> forwardLinks = new Stack<string>();

        private static NewTabUserControl _instance;
        public static NewTabUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NewTabUserControl();
                return _instance;
            }
        }

        public NewTabUserControl()
        {
            InitializeComponent();
        }

        //Tool Strip 

        //Back Button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(backLinks.ToString());
            
            try
            {
                string url = txtBoxAddressbar.Text;
                forwardLinks.Push(url);

                string newUrl = backLinks.Pop();
                webBrowser1.Navigate(newUrl);
                txtBoxAddressbar.Text = newUrl;
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Null Error To Go Backwards");
            }
        }

        //Forward Button
        private void btnForward_Click(object sender, EventArgs e)
        {
           
            try
            {
                string url = txtBoxAddressbar.Text;
                backLinks.Push(url);

                string newUrl = forwardLinks.Pop();
                webBrowser1.Navigate(newUrl);
                txtBoxAddressbar.Text = newUrl;
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Null Error To Go Forwards");
            }
            
        }

        //Refresh Button
        private void btnRefresh_Click(object sender, EventArgs e)
        {
             webBrowser1.Refresh();
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
                    
                    //adds url to stack
                    backLinks.Push(url);
                    forwardLinks.Push(url);

                    
                }
            }
        }
        //Go Button
        private void btnGo_Click_1(object sender, EventArgs e)
        {
            string url = txtBoxAddressbar.Text;
            webBrowser1.Navigate(url);
            webBrowser1.ScriptErrorsSuppressed = true;

            //adds url to stacks 
            backLinks.Push(url);
            forwardLinks.Push(url);

            string[] title = url.Split('.');

            int titleIdx;

            if (title[0].Equals("www"))
            {
                titleIdx = 1;
            }
            else
            {
                titleIdx = 0;
            }


            HistoryManager.AddItem(url, title[titleIdx]);

        }

        //A Bookmark button: when clicked, the URL and Title of the current page will be added to 
        //the Bookmark table in the database if it does not already exist (use the Bookmark Manager 
        //to add the new bookmark to the database)
        private void btnBookmark_Click(object sender, EventArgs e)
        {
             string url = txtBoxAddressbar.Text;
             string[] title = url.Split('.');
             int titleIdx;

            if (title[0].Equals("www"))
            {
                titleIdx = 1;
            } else
            {
                titleIdx = 0;
            }
            
             
             BookmarkManager.AddItem(url, title[titleIdx]);

        }
    }
}
