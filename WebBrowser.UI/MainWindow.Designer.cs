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
            this.components = new System.ComponentModel.Container();
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
            this.browserHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyDataSet = new WebBrowser.UI.HistoryDataSet();
            this.bookmarkDataSet = new WebBrowser.UI.BookmarkDataSet();
            this.browserBookmarkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.browserBookmarkTableAdapter = new WebBrowser.UI.BookmarkDataSetTableAdapters.browserBookmarkTableAdapter();
            this.tableAdapterManager1 = new WebBrowser.UI.BookmarkDataSetTableAdapters.TableAdapterManager();
            this.browserHistoryTableAdapter = new WebBrowser.UI.HistoryDataSetTableAdapters.browserHistoryTableAdapter();
            this.tableAdapterManager = new WebBrowser.UI.HistoryDataSetTableAdapters.TableAdapterManager();
            this.browserDatabaseDataSet = new WebBrowser.UI.BrowserDatabaseDataSet();
            this.browserHistoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.browserHistoryTableAdapter1 = new WebBrowser.UI.BrowserDatabaseDataSetTableAdapters.browserHistoryTableAdapter();
            this.tableAdapterManager2 = new WebBrowser.UI.BrowserDatabaseDataSetTableAdapters.TableAdapterManager();
            this.browserHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserBookmarkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserHistoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserHistoryDataGridView)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1865, 40);
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
            this.fileMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileMenuItem.Text = "File";
            // 
            // newTabMenuItem
            // 
            this.newTabMenuItem.Name = "newTabMenuItem";
            this.newTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newTabMenuItem.Size = new System.Drawing.Size(427, 44);
            this.newTabMenuItem.Text = "New Tab";
            this.newTabMenuItem.Click += new System.EventHandler(this.NewTabMenuItem_Click);
            // 
            // closeCurrentTabMenuItem
            // 
            this.closeCurrentTabMenuItem.Name = "closeCurrentTabMenuItem";
            this.closeCurrentTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeCurrentTabMenuItem.Size = new System.Drawing.Size(427, 44);
            this.closeCurrentTabMenuItem.Text = "Close Current Tab";
            this.closeCurrentTabMenuItem.Click += new System.EventHandler(this.CloseCurrentTabMenuItem_Click);
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
            this.toolsMenuItem.Size = new System.Drawing.Size(90, 36);
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
            this.HelpMenuItem.Size = new System.Drawing.Size(85, 36);
            this.HelpMenuItem.Text = "Help";
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Location = new System.Drawing.Point(0, 43);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(1853, 976);
            this.tabPage.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.browserHistoryDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1837, 929);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // browserHistoryBindingSource
            // 
            this.browserHistoryBindingSource.DataMember = "browserHistory";
            this.browserHistoryBindingSource.DataSource = this.historyDataSet;
            // 
            // historyDataSet
            // 
            this.historyDataSet.DataSetName = "HistoryDataSet";
            this.historyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookmarkDataSet
            // 
            this.bookmarkDataSet.DataSetName = "BookmarkDataSet";
            this.bookmarkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // browserBookmarkBindingSource
            // 
            this.browserBookmarkBindingSource.DataMember = "browserBookmark";
            this.browserBookmarkBindingSource.DataSource = this.bookmarkDataSet;
            // 
            // browserBookmarkTableAdapter
            // 
            this.browserBookmarkTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.browserBookmarkTableAdapter = this.browserBookmarkTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WebBrowser.UI.BookmarkDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // browserHistoryTableAdapter
            // 
            this.browserHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.browserHistoryTableAdapter = this.browserHistoryTableAdapter;
            this.tableAdapterManager.UpdateOrder = WebBrowser.UI.HistoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // browserDatabaseDataSet
            // 
            this.browserDatabaseDataSet.DataSetName = "BrowserDatabaseDataSet";
            this.browserDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // browserHistoryBindingSource1
            // 
            this.browserHistoryBindingSource1.DataMember = "browserHistory";
            this.browserHistoryBindingSource1.DataSource = this.browserDatabaseDataSet;
            // 
            // browserHistoryTableAdapter1
            // 
            this.browserHistoryTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.browserBookmarksTableAdapter = null;
            this.tableAdapterManager2.browserHistoryTableAdapter = this.browserHistoryTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = WebBrowser.UI.BrowserDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // browserHistoryDataGridView
            // 
            this.browserHistoryDataGridView.AutoGenerateColumns = false;
            this.browserHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.browserHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.browserHistoryDataGridView.DataSource = this.browserHistoryBindingSource1;
            this.browserHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserHistoryDataGridView.Location = new System.Drawing.Point(3, 3);
            this.browserHistoryDataGridView.Name = "browserHistoryDataGridView";
            this.browserHistoryDataGridView.RowHeadersWidth = 82;
            this.browserHistoryDataGridView.RowTemplate.Height = 33;
            this.browserHistoryDataGridView.Size = new System.Drawing.Size(1831, 923);
            this.browserHistoryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "URL";
            this.dataGridViewTextBoxColumn2.HeaderText = "URL";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
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
            this.Load += new System.EventHandler(this.MainWindow_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.browserHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookmarkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserBookmarkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserHistoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.browserHistoryDataGridView)).EndInit();
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
        private HistoryDataSet historyDataSet;
        private System.Windows.Forms.BindingSource browserHistoryBindingSource;
        private HistoryDataSetTableAdapters.browserHistoryTableAdapter browserHistoryTableAdapter;
        private HistoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BookmarkDataSet bookmarkDataSet;
        private System.Windows.Forms.BindingSource browserBookmarkBindingSource;
        private BookmarkDataSetTableAdapters.browserBookmarkTableAdapter browserBookmarkTableAdapter;
        private BookmarkDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private BrowserDatabaseDataSet browserDatabaseDataSet;
        private System.Windows.Forms.BindingSource browserHistoryBindingSource1;
        private BrowserDatabaseDataSetTableAdapters.browserHistoryTableAdapter browserHistoryTableAdapter1;
        private BrowserDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView browserHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}