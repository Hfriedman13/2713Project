namespace WebBrowser.UI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsHTMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHistoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookmarksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.newTabUserControl1 = new WebBrowser.UI.NewTabUserControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.toolsMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1865, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabMenuItem,
            this.closeCurrentTabMenuItem,
            this.saveAsHTMLMenuItem,
            this.printPageMenuItem,
            this.ExitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileMenuItem.Text = "File";
            // 
            // newTabMenuItem
            // 
            this.newTabMenuItem.Name = "newTabMenuItem";
            this.newTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabMenuItem.Size = new System.Drawing.Size(427, 44);
            this.newTabMenuItem.Text = "New Tab";
            this.newTabMenuItem.Click += new System.EventHandler(this.newTabMenuItem_Click);
            // 
            // closeCurrentTabMenuItem
            // 
            this.closeCurrentTabMenuItem.Name = "closeCurrentTabMenuItem";
            this.closeCurrentTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeCurrentTabMenuItem.Size = new System.Drawing.Size(427, 44);
            this.closeCurrentTabMenuItem.Text = "Close Current Tab";
            this.closeCurrentTabMenuItem.Click += new System.EventHandler(this.closeCurrentTabMenuItem_Click);
            // 
            // saveAsHTMLMenuItem
            // 
            this.saveAsHTMLMenuItem.Name = "saveAsHTMLMenuItem";
            this.saveAsHTMLMenuItem.Size = new System.Drawing.Size(427, 44);
            this.saveAsHTMLMenuItem.Text = "Save as HTML";
            // 
            // printPageMenuItem
            // 
            this.printPageMenuItem.Name = "printPageMenuItem";
            this.printPageMenuItem.Size = new System.Drawing.Size(427, 44);
            this.printPageMenuItem.Text = "Print Page";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(427, 44);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryMenuItem,
            this.manageBookmarksMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(90, 38);
            this.toolsMenuItem.Text = "Tools";
            // 
            // manageHistoryMenuItem
            // 
            this.manageHistoryMenuItem.Name = "manageHistoryMenuItem";
            this.manageHistoryMenuItem.Size = new System.Drawing.Size(360, 44);
            this.manageHistoryMenuItem.Text = "Manage History";
            // 
            // manageBookmarksMenuItem
            // 
            this.manageBookmarksMenuItem.Name = "manageBookmarksMenuItem";
            this.manageBookmarksMenuItem.Size = new System.Drawing.Size(360, 44);
            this.manageBookmarksMenuItem.Text = "Manage Bookmarks";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(85, 38);
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Location = new System.Drawing.Point(0, 88);
            this.tabPage.Name = "tabControl1";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1853, 976);
            this.tabPage.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.newTabUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1837, 929);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // newTabUserControl1
            // 
            this.newTabUserControl1.Location = new System.Drawing.Point(0, 3);
            this.newTabUserControl1.Name = "newTabUserControl1";
            this.newTabUserControl1.Size = new System.Drawing.Size(1837, 926);
            this.newTabUserControl1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 1210);
            this.Controls.Add(this.tabPage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsHTMLMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private NewTabUserControl newTabUserControl1;
        public System.Windows.Forms.TabControl tabPage;
    }
}