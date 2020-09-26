using System;
using System.Collections.Generic;
using System.Text;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(string url, string title)
        { 
            var adapter = new browserHistoryTableAdapter();
            adapter.Insert(url, title, DateTime.Now);
            
        }

        public static List<HistoryItem> GetItems()
        {
            var adapter = new browserHistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.ID = row.Id;

                results.Add(item);
            }

            return results;

        }
        

    }
}
