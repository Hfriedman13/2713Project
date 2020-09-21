using System;
using System.Collections.Generic;
using System.Text;


namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public String URL { get; set; }
        public String Title { get; set; }
        public DateTime Date { get; set; }
        public int ID { get; set; }
    }
}
