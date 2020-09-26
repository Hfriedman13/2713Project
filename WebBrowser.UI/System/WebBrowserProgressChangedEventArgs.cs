namespace System
{
    internal class WebBrowserProgressChangedEventArgs
    {
        internal readonly int CurrentProgress;
        private Action<object, Windows.Forms.WebBrowserProgressChangedEventArgs> btnGo_Click_1;
        private Action<object, WebBrowserProgressChangedEventArgs> btnGo_Click_11;
        private Action<object, WebBrowserProgressChangedEventArgs> btnGo_Click_12;

        public WebBrowserProgressChangedEventArgs(Action<object, Windows.Forms.WebBrowserProgressChangedEventArgs> btnGo_Click_1)
        {
            this.btnGo_Click_1 = btnGo_Click_1;
        }

        public WebBrowserProgressChangedEventArgs(Action<object, WebBrowserProgressChangedEventArgs> btnGo_Click_11)
        {
            this.btnGo_Click_11 = btnGo_Click_11;
        }

        
    }
}