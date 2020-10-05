using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WebBrowser.UI.BrowserDatabaseDataSetTableAdapters;

namespace WebBrowser.UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        //MENU ITEMS
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //HELP MENU 
        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hannah Friedman, hzf0023" + "\n" + 
                "This is my very first web browser as well as my first large project with c#" +
                "\n" + "I am very excited about creating this and cant wait to explore more of Win. Forms!");

        }
        //OPEN New Tab
        private void NewTabMenuItem_Click(object sender, EventArgs e)
        {

                string title = "New Tab   "; //"TabPage" + (tabPage.TabCount + 1).ToString() + "    .";
                TabPage myTabPage = new TabPage(title);
                tabPage.TabPages.Add(myTabPage);

                myTabPage.Controls.Add(new NewTabUserControl(myTabPage));
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
            string title = "New Tab   ";
            TabPage myTabPage = new TabPage(title);

            tabPage1.Controls.Add(new NewTabUserControl(myTabPage));
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
            var tabPage1 = this.tabPage.TabPages[e.Index];
            var tabRect = this.tabPage.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            if (e.Index == this.tabPage.TabCount - 1)
            {
                var addImage = Properties.Resources.addTab;
                e.Graphics.DrawImage(addImage,
                    tabRect.Left + (tabRect.Width - addImage.Width) / 2,
                    tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                var closeImage = Properties.Resources.deleteTab;
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage1.Text, tabPage1.Font,
                    tabRect, tabPage1.ForeColor, TextFormatFlags.Left);
            }
        }

        private void tabPage_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabPage.TabCount - 1)
                e.Cancel = true;
        }

        private void tabPage_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabPage.TabCount - 1;

            if (this.tabPage.GetTabRect(lastIndex).Contains(e.Location))
            {
                this.tabPage.SelectedIndex = lastIndex;
                string title = "New Tab   ";
                TabPage myTabPage = new TabPage(title);
                tabPage.TabPages.Add(myTabPage);

                myTabPage.Controls.Add(new NewTabUserControl(myTabPage));
                NewTabUserControl.Instance.Dock = DockStyle.Fill;
                NewTabUserControl.Instance.BringToFront();
            }
            else
            {
                for (var i = 0; i < this.tabPage.TabPages.Count; i++)
                {
                    var tabRect = this.tabPage.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.deleteTab;
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width,
                        closeImage.Height);
                    if (imageRect.Contains(e.Location))
                    {
                        this.tabPage.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }


        }

        //PRINTING 
        //private void printPageMenuItem_Click(object sender, EventArgs e)
        //{

        //}


        //SAVING PAGE 
        private void saveAsHTMLMenuItem_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                FileStream fs =
                    (FileStream)saveFileDialog1.OpenFile();
        

                fs.Close();
            }
        }

    }

}

    


