using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.UI.BrowserDatabaseDataSetTableAdapters;

namespace WebBrowser.UI
{
    public partial class MainWindow : Form
    {
        private Button printButton;
        private Font printFont;
        private StreamReader streamToPrint;
        public MainWindow()
        {
            InitializeComponent();
            this.components = new Container();
            this.printButton = new Button();

            this.ClientSize = new Size(504, 381);
            this.Text = "Print Example";

            printButton.ImageAlign = ContentAlignment.MiddleLeft;
            printButton.Location = new Point(32, 110);
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.TabIndex = 0;
            printButton.Text = "Print the file.";
            printButton.Size = new Size(136, 40);
            printButton.Click += new EventHandler(printPageMenuItem_Click);

            this.Controls.Add(printButton);

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
        //Creating New Tab
        private void NewTabMenuItem_Click(object sender, EventArgs e)
        {
                
                string title = "TabPage" + (tabPage.TabCount + 1).ToString() + "    .";
                TabPage myTabPage = new TabPage(title);
                tabPage.TabPages.Add(myTabPage);

                myTabPage.Controls.Add(new NewTabUserControl());
                NewTabUserControl.Instance.Dock = DockStyle.Fill;
                NewTabUserControl.Instance.BringToFront();
        }
    
        //CLOSING TAB
        private void CloseCurrentTabMenuItem_Click(object sender, EventArgs e)
        {
            // Removes the selected tab:  
            tabPage.TabPages.Remove(tabPage.SelectedTab); 
        }

        //MAIN ON LOAD
        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            string title = "TabPage ";
            TabPage myTabPage = new TabPage(title);

            tabPage1.Controls.Add(new NewTabUserControl());
            NewTabUserControl.Instance.Dock = DockStyle.Fill;
            NewTabUserControl.Instance.BringToFront();
        }

        //MANAGE BOOKMARKS
        private void manageBookmarksMenuItem_Click(object sender, EventArgs e)
        {
            var BookmarkForm = new BookmarkManagerForm();
            BookmarkForm.ShowDialog();
        }
        //MANAGE HISTORY
        private void manageHistoryMenuItem_Click(object sender, EventArgs e)
        {
            var HistoryForm = new HistoryManagerForm();
            HistoryForm.ShowDialog();
        }
        //CLEAR HISTORY
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var adapter = new browserHistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title, row.Date);
            }

        }

        //TAB CONTROL OPEN / CLOSE
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabPage.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// If the last TabPage is selected then Create a new TabPage
            //if (tabPage.SelectedIndex == tabPage.TabPages.Count - 1)
            //    tabPage.TabPages.Add(tabPage1);
        }

        private void tabPage_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabPage.TabPages.Count; i++)
            {
                Rectangle r = tabPage.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);

                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabPage.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }

        }
        //PRINTING 
        private void printPageMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                streamToPrint = new StreamReader
                   ("C:/WebBrowser/testing.txt");
                try
                {
                    printFont = new Font("Arial", 10);
                    PrintDocument pd = new PrintDocument();
                    pd.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    pd.Print();
                }
                finally
                {
                    streamToPrint.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // The PrintPage event is raised for each page to be printed.
        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;

            // Calculate the number of lines per page.
            linesPerPage = ev.MarginBounds.Height /
               printFont.GetHeight(ev.Graphics);

            // Print each line of the file.
            while (count < linesPerPage &&
               ((line = streamToPrint.ReadLine()) != null))
            {
                yPos = topMargin + (count *
                   printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black,
                   leftMargin, yPos, new StringFormat());
                count++;
            }

            // If more lines exist, print another page.
            if (line != null)
                ev.HasMorePages = true;
            else
                ev.HasMorePages = false;
        }
    }

}

    


