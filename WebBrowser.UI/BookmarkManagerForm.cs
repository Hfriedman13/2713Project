using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using WebBrowser.UI.BrowserDatabaseDataSetTableAdapters;

namespace WebBrowser.UI
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            lbBookmark.Items.Clear();

            foreach (var item in items)
            {
                lbBookmark.Items.Add(string.Format("{1} - {0}", item.Title, item.URL));
               
            }
        }

        private void btnSearchBm_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            lbBookmark.Items.Clear();

            foreach (var item in items)
            {

                if (item.URL.Contains(tbSearchBm.Text) || item.Title.Contains(tbSearchBm.Text))
                {
                    BookmarkManager.AddItem(item.URL, item.Title);
                    lbBookmark.Items.Add(string.Format("{1} - {0}", item.Title, item.URL));
                }

            }
        }

        private void btnDeleteBm_Click(object sender, EventArgs e)
        {
            var items = lbBookmark.SelectedItem;
            lbBookmark.Items.Remove(items);
            //need to connect database
        }
    }
}
