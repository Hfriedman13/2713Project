namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.lbBookmark = new System.Windows.Forms.ListBox();
            this.tbSearchBm = new System.Windows.Forms.TextBox();
            this.btnSearchBm = new System.Windows.Forms.Button();
            this.btnDeleteBm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbBookmark
            // 
            this.lbBookmark.FormattingEnabled = true;
            this.lbBookmark.ItemHeight = 25;
            this.lbBookmark.Location = new System.Drawing.Point(168, 219);
            this.lbBookmark.Name = "lbBookmark";
            this.lbBookmark.Size = new System.Drawing.Size(953, 404);
            this.lbBookmark.TabIndex = 0;
            // 
            // tbSearchBm
            // 
            this.tbSearchBm.Location = new System.Drawing.Point(500, 182);
            this.tbSearchBm.Name = "tbSearchBm";
            this.tbSearchBm.Size = new System.Drawing.Size(468, 31);
            this.tbSearchBm.TabIndex = 1;
            // 
            // btnSearchBm
            // 
            this.btnSearchBm.Location = new System.Drawing.Point(986, 170);
            this.btnSearchBm.Name = "btnSearchBm";
            this.btnSearchBm.Size = new System.Drawing.Size(127, 43);
            this.btnSearchBm.TabIndex = 2;
            this.btnSearchBm.Text = "Search";
            this.btnSearchBm.UseVisualStyleBackColor = true;
            this.btnSearchBm.Click += new System.EventHandler(this.btnSearchBm_Click);
            // 
            // btnDeleteBm
            // 
            this.btnDeleteBm.Location = new System.Drawing.Point(986, 647);
            this.btnDeleteBm.Name = "btnDeleteBm";
            this.btnDeleteBm.Size = new System.Drawing.Size(127, 50);
            this.btnDeleteBm.TabIndex = 3;
            this.btnDeleteBm.Text = "Delete";
            this.btnDeleteBm.UseVisualStyleBackColor = true;
            this.btnDeleteBm.Click += new System.EventHandler(this.btnDeleteBm_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 709);
            this.Controls.Add(this.btnDeleteBm);
            this.Controls.Add(this.btnSearchBm);
            this.Controls.Add(this.tbSearchBm);
            this.Controls.Add(this.lbBookmark);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBookmark;
        private System.Windows.Forms.TextBox tbSearchBm;
        private System.Windows.Forms.Button btnSearchBm;
        private System.Windows.Forms.Button btnDeleteBm;
    }
}