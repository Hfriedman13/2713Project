using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WebBrowser.Data.BookmarkDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddItem(string url, string title)
        {
            
            var adapter = new browserBookmarksTableAdapter();
            //adapter.Insert(item.URL, item.Title);
            adapter.Insert(url, title);
        }

     
        public static List<BookmarkItem> GetItems()
        {
            var adapter = new browserBookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.ID = row.Id;

                results.Add(item);

            }

            return results;
        }
    }
}
