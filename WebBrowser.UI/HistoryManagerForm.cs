using System;
using System.Collections;
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
            lbHistory.Items.Clear();

            foreach (var item in items)
            {
                
                if (item.URL.Contains(tbSearch.Text) || item.Title.Contains(tbSearch.Text))
                { 
                    HistoryManager.AddItem(item.URL, item.Title);
                    lbHistory.Items.Add(string.Format("{2} - {1} - {0}", item.Date, item.Title, item.URL));
                }
 
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();
            var adapter = new browserHistoryTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                adapter.Delete(row.Id, row.URL, row.Title, row.Date);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            //needs to save item the was removed
            var items = lbHistory.SelectedItem;
            lbHistory.Items.Remove(items);

           
        }
    }
}
