namespace CurrencyReplacer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSearch = new System.Windows.Forms.Button();
            this.folderBrowserDialogMore = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tbSourceFolder = new System.Windows.Forms.TextBox();
            this.tbDestinationFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMoreBrowse = new System.Windows.Forms.Button();
            this.btnLessBrowse = new System.Windows.Forms.Button();
            this.folderBrowserDialogLess = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.Color.Green;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(420, 50);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 209);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(420, 43);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            this.progressBar.Tag = "";
            // 
            // tbSourceFolder
            // 
            this.tbSourceFolder.Location = new System.Drawing.Point(12, 129);
            this.tbSourceFolder.Name = "tbSourceFolder";
            this.tbSourceFolder.ReadOnly = true;
            this.tbSourceFolder.Size = new System.Drawing.Size(168, 20);
            this.tbSourceFolder.TabIndex = 2;
            this.tbSourceFolder.Text = "Source path";
            this.tbSourceFolder.MouseLeave += new System.EventHandler(this.TbSourceFolder_MouseLeave);
            this.tbSourceFolder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TbSourceFolder_MouseMove);
            // 
            // tbDestinationFolder
            // 
            this.tbDestinationFolder.Location = new System.Drawing.Point(209, 129);
            this.tbDestinationFolder.Name = "tbDestinationFolder";
            this.tbDestinationFolder.ReadOnly = true;
            this.tbDestinationFolder.Size = new System.Drawing.Size(199, 20);
            this.tbDestinationFolder.TabIndex = 3;
            this.tbDestinationFolder.Text = "Destination path";
            this.tbDestinationFolder.MouseLeave += new System.EventHandler(this.TbDestinationFolder_MouseLeave);
            this.tbDestinationFolder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TbDestinationFolder_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Source Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(204, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination Folder:";
            // 
            // btnMoreBrowse
            // 
            this.btnMoreBrowse.Location = new System.Drawing.Point(13, 156);
            this.btnMoreBrowse.Name = "btnMoreBrowse";
            this.btnMoreBrowse.Size = new System.Drawing.Size(167, 23);
            this.btnMoreBrowse.TabIndex = 6;
            this.btnMoreBrowse.Text = "Browse...";
            this.btnMoreBrowse.UseVisualStyleBackColor = true;
            this.btnMoreBrowse.Click += new System.EventHandler(this.BtnMoreBrowse_Click);
            // 
            // btnLessBrowse
            // 
            this.btnLessBrowse.Location = new System.Drawing.Point(209, 155);
            this.btnLessBrowse.Name = "btnLessBrowse";
            this.btnLessBrowse.Size = new System.Drawing.Size(199, 23);
            this.btnLessBrowse.TabIndex = 7;
            this.btnLessBrowse.Text = "Browse...";
            this.btnLessBrowse.UseVisualStyleBackColor = true;
            this.btnLessBrowse.Click += new System.EventHandler(this.BtnLessBrowse_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(420, 252);
            this.Controls.Add(this.btnLessBrowse);
            this.Controls.Add(this.btnMoreBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDestinationFolder);
            this.Controls.Add(this.tbSourceFolder);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search For Currency";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMore;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tbSourceFolder;
        private System.Windows.Forms.TextBox tbDestinationFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMoreBrowse;
        private System.Windows.Forms.Button btnLessBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogLess;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

