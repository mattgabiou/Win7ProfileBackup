namespace Win7ProfileBackup
{
    partial class Form1
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
               this.label1 = new System.Windows.Forms.Label();
               this.labelMyDocuments = new System.Windows.Forms.Label();
               this.buttonBackupNow = new System.Windows.Forms.Button();
               this.labelDocsStatus = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.labelDeskStatus = new System.Windows.Forms.Label();
               this.labelDesktop = new System.Windows.Forms.Label();
               this.labelDownStatus = new System.Windows.Forms.Label();
               this.labelDownloads = new System.Windows.Forms.Label();
               this.labelFavStatus = new System.Windows.Forms.Label();
               this.labelFavorites = new System.Windows.Forms.Label();
               this.menuStrip1 = new System.Windows.Forms.MenuStrip();
               this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
               this.label4BackUp = new System.Windows.Forms.Label();
               this.labelCurrentFile = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.labelDescription = new System.Windows.Forms.Label();
               this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
               this.btnOpen = new System.Windows.Forms.Button();
               this.labelNumber1 = new System.Windows.Forms.Label();
               this.labelNumber2 = new System.Windows.Forms.Label();
               this.labelPath = new System.Windows.Forms.Label();
               this.buttonLogFile = new System.Windows.Forms.Button();
               this.labelFileSearch = new System.Windows.Forms.Label();
               this.labelFileSearchStatus = new System.Windows.Forms.Label();
               this.panel1.SuspendLayout();
               this.menuStrip1.SuspendLayout();
               this.groupBox1.SuspendLayout();
               this.groupBox2.SuspendLayout();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(12, 42);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(324, 20);
               this.label1.TabIndex = 0;
               this.label1.Text = "Windows 7 Backup Utility (for Win7/Vista/XP)";
               // 
               // labelMyDocuments
               // 
               this.labelMyDocuments.AutoSize = true;
               this.labelMyDocuments.Location = new System.Drawing.Point(20, 130);
               this.labelMyDocuments.Name = "labelMyDocuments";
               this.labelMyDocuments.Size = new System.Drawing.Size(78, 13);
               this.labelMyDocuments.TabIndex = 1;
               this.labelMyDocuments.Text = "My Documents";
               // 
               // buttonBackupNow
               // 
               this.buttonBackupNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonBackupNow.Location = new System.Drawing.Point(64, 198);
               this.buttonBackupNow.Name = "buttonBackupNow";
               this.buttonBackupNow.Size = new System.Drawing.Size(121, 45);
               this.buttonBackupNow.TabIndex = 2;
               this.buttonBackupNow.Text = "Start Backup";
               this.buttonBackupNow.UseVisualStyleBackColor = true;
               this.buttonBackupNow.Click += new System.EventHandler(this.buttonBackupNow_Click);
               // 
               // labelDocsStatus
               // 
               this.labelDocsStatus.AutoSize = true;
               this.labelDocsStatus.Location = new System.Drawing.Point(204, 130);
               this.labelDocsStatus.MaximumSize = new System.Drawing.Size(250, 0);
               this.labelDocsStatus.Name = "labelDocsStatus";
               this.labelDocsStatus.Size = new System.Drawing.Size(81, 13);
               this.labelDocsStatus.TabIndex = 3;
               this.labelDocsStatus.Text = "Not Backed Up";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(19, 14);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(81, 20);
               this.label2.TabIndex = 4;
               this.label2.Text = "Directory";
               this.label2.Click += new System.EventHandler(this.label2_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(203, 14);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(62, 20);
               this.label3.TabIndex = 5;
               this.label3.Text = "Status";
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.labelFileSearchStatus);
               this.panel1.Controls.Add(this.labelFileSearch);
               this.panel1.Controls.Add(this.labelDeskStatus);
               this.panel1.Controls.Add(this.labelDesktop);
               this.panel1.Controls.Add(this.labelDownStatus);
               this.panel1.Controls.Add(this.labelDownloads);
               this.panel1.Controls.Add(this.labelFavStatus);
               this.panel1.Controls.Add(this.labelFavorites);
               this.panel1.Controls.Add(this.label2);
               this.panel1.Controls.Add(this.labelDocsStatus);
               this.panel1.Controls.Add(this.label3);
               this.panel1.Controls.Add(this.labelMyDocuments);
               this.panel1.Location = new System.Drawing.Point(6, 11);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(553, 205);
               this.panel1.TabIndex = 6;
               // 
               // labelDeskStatus
               // 
               this.labelDeskStatus.AutoSize = true;
               this.labelDeskStatus.Location = new System.Drawing.Point(204, 107);
               this.labelDeskStatus.Name = "labelDeskStatus";
               this.labelDeskStatus.Size = new System.Drawing.Size(81, 13);
               this.labelDeskStatus.TabIndex = 11;
               this.labelDeskStatus.Text = "Not Backed Up";
               // 
               // labelDesktop
               // 
               this.labelDesktop.AutoSize = true;
               this.labelDesktop.Location = new System.Drawing.Point(20, 107);
               this.labelDesktop.Name = "labelDesktop";
               this.labelDesktop.Size = new System.Drawing.Size(47, 13);
               this.labelDesktop.TabIndex = 10;
               this.labelDesktop.Text = "Desktop";
               // 
               // labelDownStatus
               // 
               this.labelDownStatus.AutoSize = true;
               this.labelDownStatus.Location = new System.Drawing.Point(204, 85);
               this.labelDownStatus.Name = "labelDownStatus";
               this.labelDownStatus.Size = new System.Drawing.Size(81, 13);
               this.labelDownStatus.TabIndex = 9;
               this.labelDownStatus.Text = "Not Backed Up";
               // 
               // labelDownloads
               // 
               this.labelDownloads.AutoSize = true;
               this.labelDownloads.Location = new System.Drawing.Point(20, 85);
               this.labelDownloads.Name = "labelDownloads";
               this.labelDownloads.Size = new System.Drawing.Size(60, 13);
               this.labelDownloads.TabIndex = 8;
               this.labelDownloads.Text = "Downloads";
               // 
               // labelFavStatus
               // 
               this.labelFavStatus.AutoSize = true;
               this.labelFavStatus.Location = new System.Drawing.Point(204, 62);
               this.labelFavStatus.Name = "labelFavStatus";
               this.labelFavStatus.Size = new System.Drawing.Size(81, 13);
               this.labelFavStatus.TabIndex = 7;
               this.labelFavStatus.Text = "Not Backed Up";
               // 
               // labelFavorites
               // 
               this.labelFavorites.AutoSize = true;
               this.labelFavorites.Location = new System.Drawing.Point(20, 62);
               this.labelFavorites.Name = "labelFavorites";
               this.labelFavorites.Size = new System.Drawing.Size(50, 13);
               this.labelFavorites.TabIndex = 6;
               this.labelFavorites.Text = "Favorites";
               // 
               // menuStrip1
               // 
               this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
               this.menuStrip1.Location = new System.Drawing.Point(0, 0);
               this.menuStrip1.Name = "menuStrip1";
               this.menuStrip1.Size = new System.Drawing.Size(591, 24);
               this.menuStrip1.TabIndex = 7;
               this.menuStrip1.Text = "menuStrip1";
               // 
               // fileToolStripMenuItem
               // 
               this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
               this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
               this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
               this.fileToolStripMenuItem.Text = "&File";
               // 
               // exitToolStripMenuItem
               // 
               this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
               this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
               this.exitToolStripMenuItem.Text = "&Exit";
               this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
               // 
               // helpToolStripMenuItem
               // 
               this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
               this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
               this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
               this.helpToolStripMenuItem.Text = "&Help";
               // 
               // aboutToolStripMenuItem
               // 
               this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
               this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
               this.aboutToolStripMenuItem.Text = "&About";
               this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
               // 
               // label4BackUp
               // 
               this.label4BackUp.AutoSize = true;
               this.label4BackUp.Location = new System.Drawing.Point(6, 16);
               this.label4BackUp.Name = "label4BackUp";
               this.label4BackUp.Size = new System.Drawing.Size(66, 13);
               this.label4BackUp.TabIndex = 8;
               this.label4BackUp.Text = "Backing Up:";
               // 
               // labelCurrentFile
               // 
               this.labelCurrentFile.AutoSize = true;
               this.labelCurrentFile.Location = new System.Drawing.Point(78, 16);
               this.labelCurrentFile.MaximumSize = new System.Drawing.Size(460, 0);
               this.labelCurrentFile.Name = "labelCurrentFile";
               this.labelCurrentFile.Size = new System.Drawing.Size(0, 13);
               this.labelCurrentFile.TabIndex = 9;
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.label4BackUp);
               this.groupBox1.Controls.Add(this.labelCurrentFile);
               this.groupBox1.Location = new System.Drawing.Point(16, 495);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Size = new System.Drawing.Size(559, 86);
               this.groupBox1.TabIndex = 10;
               this.groupBox1.TabStop = false;
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.panel1);
               this.groupBox2.Location = new System.Drawing.Point(16, 267);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Size = new System.Drawing.Size(559, 222);
               this.groupBox2.TabIndex = 12;
               this.groupBox2.TabStop = false;
               // 
               // labelDescription
               // 
               this.labelDescription.Location = new System.Drawing.Point(13, 61);
               this.labelDescription.MaximumSize = new System.Drawing.Size(460, 0);
               this.labelDescription.Name = "labelDescription";
               this.labelDescription.Size = new System.Drawing.Size(460, 0);
               this.labelDescription.TabIndex = 7;
               this.labelDescription.Text = "This utility backs Windows profile data to your H drive under the ProfileBackup f" +
    "older. Please choose the folder to backup to.";
               this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
               // 
               // folderBrowserDialog1
               // 
               this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
               // 
               // btnOpen
               // 
               this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnOpen.Location = new System.Drawing.Point(64, 117);
               this.btnOpen.Name = "btnOpen";
               this.btnOpen.Size = new System.Drawing.Size(121, 45);
               this.btnOpen.TabIndex = 13;
               this.btnOpen.Text = "Backup Folder";
               this.btnOpen.UseVisualStyleBackColor = true;
               this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
               // 
               // labelNumber1
               // 
               this.labelNumber1.AutoSize = true;
               this.labelNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNumber1.Location = new System.Drawing.Point(12, 121);
               this.labelNumber1.Name = "labelNumber1";
               this.labelNumber1.Size = new System.Drawing.Size(37, 31);
               this.labelNumber1.TabIndex = 14;
               this.labelNumber1.Text = "1.";
               // 
               // labelNumber2
               // 
               this.labelNumber2.AutoSize = true;
               this.labelNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNumber2.Location = new System.Drawing.Point(16, 199);
               this.labelNumber2.Name = "labelNumber2";
               this.labelNumber2.Size = new System.Drawing.Size(37, 31);
               this.labelNumber2.TabIndex = 15;
               this.labelNumber2.Text = "2.";
               // 
               // labelPath
               // 
               this.labelPath.AutoSize = true;
               this.labelPath.Location = new System.Drawing.Point(202, 133);
               this.labelPath.Name = "labelPath";
               this.labelPath.Size = new System.Drawing.Size(22, 13);
               this.labelPath.TabIndex = 16;
               this.labelPath.Text = "C:\\";
               // 
               // buttonLogFile
               // 
               this.buttonLogFile.Location = new System.Drawing.Point(513, 209);
               this.buttonLogFile.Name = "buttonLogFile";
               this.buttonLogFile.Size = new System.Drawing.Size(62, 23);
               this.buttonLogFile.TabIndex = 12;
               this.buttonLogFile.Text = "LogFile";
               this.buttonLogFile.UseVisualStyleBackColor = true;
               this.buttonLogFile.Click += new System.EventHandler(this.buttonLogFile_Click);
               // 
               // labelFileSearch
               // 
               this.labelFileSearch.AutoSize = true;
               this.labelFileSearch.Location = new System.Drawing.Point(20, 164);
               this.labelFileSearch.Name = "labelFileSearch";
               this.labelFileSearch.Size = new System.Drawing.Size(60, 13);
               this.labelFileSearch.TabIndex = 12;
               this.labelFileSearch.Text = "File Search";
               // 
               // labelFileSearchStatus
               // 
               this.labelFileSearchStatus.AutoSize = true;
               this.labelFileSearchStatus.Location = new System.Drawing.Point(204, 164);
               this.labelFileSearchStatus.Name = "labelFileSearchStatus";
               this.labelFileSearchStatus.Size = new System.Drawing.Size(73, 13);
               this.labelFileSearchStatus.TabIndex = 13;
               this.labelFileSearchStatus.Text = "Not Searched";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(591, 597);
               this.Controls.Add(this.buttonLogFile);
               this.Controls.Add(this.labelPath);
               this.Controls.Add(this.labelNumber2);
               this.Controls.Add(this.labelNumber1);
               this.Controls.Add(this.btnOpen);
               this.Controls.Add(this.labelDescription);
               this.Controls.Add(this.groupBox2);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.buttonBackupNow);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.menuStrip1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.MainMenuStrip = this.menuStrip1;
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Windows 7 Backup Utility";
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.menuStrip1.ResumeLayout(false);
               this.menuStrip1.PerformLayout();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.groupBox2.ResumeLayout(false);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMyDocuments;
        private System.Windows.Forms.Button buttonBackupNow;
        private System.Windows.Forms.Label labelDocsStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDownStatus;
        private System.Windows.Forms.Label labelDownloads;
        private System.Windows.Forms.Label labelFavStatus;
        private System.Windows.Forms.Label labelFavorites;
        private System.Windows.Forms.Label labelDeskStatus;
        private System.Windows.Forms.Label labelDesktop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label4BackUp;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label labelNumber1;
        private System.Windows.Forms.Label labelNumber2;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button buttonLogFile;
        private System.Windows.Forms.Label labelFileSearchStatus;
        private System.Windows.Forms.Label labelFileSearch;
    }
}

