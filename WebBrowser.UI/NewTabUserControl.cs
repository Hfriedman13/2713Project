﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class NewTabUserControl : UserControl
    {

        public string tabTitle = "";
        TabPage tp = new TabPage();

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
        public NewTabUserControl(TabPage tab)
        {
            this.tabTitle = tab.Text;
            this.tp = tab;

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
        private void btnHome_Click(object sender, EventArgs e)
        {
            string url = "www.google.com";
            webBrowser1.Navigate(url);
            webBrowser1.ScriptErrorsSuppressed = true;
        }

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

                    title[titleIdx] = char.ToUpper(title[titleIdx].First()) + title[titleIdx].Substring(1).ToLower();
                    this.tp.Text = title[titleIdx] + "     .";
                }
            }
        }
        //Go Button
        private void btnGo_Click_1(object sender,  EventArgs e)
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

            title[titleIdx] = char.ToUpper(title[titleIdx].First()) + title[titleIdx].Substring(1).ToLower();
            this.tp.Text = title[titleIdx] + "     .";


            HistoryManager.AddItem(url, title[titleIdx]);
          

         
        }

      //Bookmark click 
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
            
             if (!hasItem(url))
            {
                BookmarkManager.AddItem(url, title[titleIdx]);
            }
             
        }

        private bool hasItem(string url)
        {
            var bml = BookmarkManager.GetItems();
           foreach(var i in bml)
            {
                if (i.URL.Equals(url))
                {
                    MessageBox.Show("Bookmark Already Exists :)");
                    return true;
                }
            }
            return false;
        }

        private void webBrowser1_ProgressChanged(object sender, System.Windows.Forms.WebBrowserProgressChangedEventArgs e)
        {
            var maxP = (int)e.MaximumProgress;
            var curr = (int)e.CurrentProgress;
            progressBar.Maximum = maxP;
            progressBar.Minimum = 0;

            if (curr > 0 && curr <= maxP)
            {
                progressBar.Value = curr;
                toolStripStatusLabel1.Text = "Loading";

            }

            if (e.CurrentProgress == maxP || e.CurrentProgress == 0) 
            {
                toolStripStatusLabel1.Text = "Done";
            }
            

        }


    }
}


