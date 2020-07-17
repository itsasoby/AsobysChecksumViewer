namespace ApexSQL_Asoby_ChecksumViewer
{
    partial class Main
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCurrentTotxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportChecksumListTotxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripFolderPathText = new System.Windows.Forms.ToolStripStatusLabel();
            this.FilesProcessedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AlgorithmSelectorDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.ProcessFilesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Filter = new System.Windows.Forms.Button();
            this.SortCritComboBox = new System.Windows.Forms.ComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FltNameAndExtTextBox = new System.Windows.Forms.TextBox();
            this.DescendingFilterCheckBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilesGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(771, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.exportCurrentTotxtToolStripMenuItem,
            this.exportChecksumListTotxtToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.openFolderToolStripMenuItem.Text = "Open folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // exportCurrentTotxtToolStripMenuItem
            // 
            this.exportCurrentTotxtToolStripMenuItem.Name = "exportCurrentTotxtToolStripMenuItem";
            this.exportCurrentTotxtToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.exportCurrentTotxtToolStripMenuItem.Text = "Export current log to .txt";
            this.exportCurrentTotxtToolStripMenuItem.Click += new System.EventHandler(this.exportCurrentTotxtToolStripMenuItem_Click);
            // 
            // exportChecksumListTotxtToolStripMenuItem
            // 
            this.exportChecksumListTotxtToolStripMenuItem.Name = "exportChecksumListTotxtToolStripMenuItem";
            this.exportChecksumListTotxtToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.exportChecksumListTotxtToolStripMenuItem.Text = "Export checksum list to .txt";
            this.exportChecksumListTotxtToolStripMenuItem.Click += new System.EventHandler(this.exportChecksumListTotxtToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FilesGridView
            // 
            this.FilesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesGridView.Location = new System.Drawing.Point(12, 261);
            this.FilesGridView.Name = "FilesGridView";
            this.FilesGridView.Size = new System.Drawing.Size(744, 241);
            this.FilesGridView.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFolderPathText,
            this.FilesProcessedStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(771, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripFolderPathText
            // 
            this.ToolStripFolderPathText.Name = "ToolStripFolderPathText";
            this.ToolStripFolderPathText.Size = new System.Drawing.Size(87, 17);
            this.ToolStripFolderPathText.Text = "No folder open";
            // 
            // FilesProcessedStatusLabel
            // 
            this.FilesProcessedStatusLabel.Name = "FilesProcessedStatusLabel";
            this.FilesProcessedStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AlgorithmSelectorDD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LogTextBox);
            this.groupBox1.Controls.Add(this.ClearListButton);
            this.groupBox1.Controls.Add(this.ProcessFilesButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 227);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Algorithm";
            // 
            // AlgorithmSelectorDD
            // 
            this.AlgorithmSelectorDD.FormattingEnabled = true;
            this.AlgorithmSelectorDD.Items.AddRange(new object[] {
            "MD5",
            "SHA 1",
            "SHA 256",
            "SHA 384",
            "SHA 512"});
            this.AlgorithmSelectorDD.Location = new System.Drawing.Point(352, 21);
            this.AlgorithmSelectorDD.Name = "AlgorithmSelectorDD";
            this.AlgorithmSelectorDD.Size = new System.Drawing.Size(189, 21);
            this.AlgorithmSelectorDD.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(25, 62);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(516, 159);
            this.LogTextBox.TabIndex = 3;
            this.LogTextBox.Text = "";
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(106, 19);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(75, 23);
            this.ClearListButton.TabIndex = 2;
            this.ClearListButton.Text = "Clear List";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // ProcessFilesButton
            // 
            this.ProcessFilesButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProcessFilesButton.Location = new System.Drawing.Point(25, 19);
            this.ProcessFilesButton.Name = "ProcessFilesButton";
            this.ProcessFilesButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessFilesButton.TabIndex = 0;
            this.ProcessFilesButton.Text = "Process files";
            this.ProcessFilesButton.UseVisualStyleBackColor = true;
            this.ProcessFilesButton.Click += new System.EventHandler(this.OpenFolderButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DescendingFilterCheckBox);
            this.groupBox2.Controls.Add(this.FltNameAndExtTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Button_Filter);
            this.groupBox2.Controls.Add(this.SortCritComboBox);
            this.groupBox2.Location = new System.Drawing.Point(586, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 221);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter name and extension";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort by";
            // 
            // Button_Filter
            // 
            this.Button_Filter.Location = new System.Drawing.Point(7, 174);
            this.Button_Filter.Name = "Button_Filter";
            this.Button_Filter.Size = new System.Drawing.Size(155, 41);
            this.Button_Filter.TabIndex = 1;
            this.Button_Filter.Text = "Apply";
            this.Button_Filter.UseVisualStyleBackColor = true;
            this.Button_Filter.Click += new System.EventHandler(this.Button_Filter_Click);
            // 
            // SortCritComboBox
            // 
            this.SortCritComboBox.FormattingEnabled = true;
            this.SortCritComboBox.Items.AddRange(new object[] {
            "None",
            "Name",
            "Size",
            "Date created",
            "Attributes"});
            this.SortCritComboBox.Location = new System.Drawing.Point(7, 45);
            this.SortCritComboBox.Name = "SortCritComboBox";
            this.SortCritComboBox.Size = new System.Drawing.Size(155, 21);
            this.SortCritComboBox.TabIndex = 0;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FltNameAndExtTextBox
            // 
            this.FltNameAndExtTextBox.Location = new System.Drawing.Point(9, 115);
            this.FltNameAndExtTextBox.Name = "FltNameAndExtTextBox";
            this.FltNameAndExtTextBox.Size = new System.Drawing.Size(153, 20);
            this.FltNameAndExtTextBox.TabIndex = 4;
            // 
            // DescendingFilterCheckBox
            // 
            this.DescendingFilterCheckBox.AutoSize = true;
            this.DescendingFilterCheckBox.Location = new System.Drawing.Point(9, 73);
            this.DescendingFilterCheckBox.Name = "DescendingFilterCheckBox";
            this.DescendingFilterCheckBox.Size = new System.Drawing.Size(83, 17);
            this.DescendingFilterCheckBox.TabIndex = 5;
            this.DescendingFilterCheckBox.Text = "Descending";
            this.DescendingFilterCheckBox.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FilesGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Asoby\'s Checksum Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilesGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportCurrentTotxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView FilesGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripFolderPathText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button ProcessFilesButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.ToolStripStatusLabel FilesProcessedStatusLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AlgorithmSelectorDD;
        private System.Windows.Forms.ToolStripMenuItem exportChecksumListTotxtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Filter;
        private System.Windows.Forms.ComboBox SortCritComboBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox FltNameAndExtTextBox;
        private System.Windows.Forms.CheckBox DescendingFilterCheckBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

