using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;
using WebBrowser.UI.BrowserDatabaseDataSetTableAdapters;

namespace WebBrowser.UI
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            lbHistory.Items.Clear();

            foreach (var item in items)
            {
                lbHistory.Items.Add(string.Format("{2} - {1} - {0}", item.Date, item.Title, item.URL));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            
            foreach (var item in items)
            {
                if (item.URL.Contains(tbSearch.Text) || item.Title.Contains(tbSearch.Text))
                {
                    lbHistory.Items.Add(item);
                    //not printing out items

                }
 
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            //not saving that list was cleared

            HistoryDataSet h = new HistoryDataSet(); 

            lbHistory.Items.Clear();
            h.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //needs to save item the was removed

            var items = lbHistory.SelectedItem;
            lbHistory.Items.Remove(items);
   
        }
    }
}
