namespace PROG7312POEPART1
{
    partial class Report_Issues_Page
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_Issues_Page));
            txtLocation = new System.Windows.Forms.TextBox();
            lstCategory = new System.Windows.Forms.ListBox();
            txtDescription = new System.Windows.Forms.RichTextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnSubmit = new System.Windows.Forms.Button();
            ReportIssuesNavigator = new System.Windows.Forms.BindingNavigator(components);
            sep = new System.Windows.Forms.ToolStripSeparator();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            drpMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            drpEvents = new System.Windows.Forms.ToolStripMenuItem();
            drpReq = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            lblRefreshQuote = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            lblFeedback = new System.Windows.Forms.ToolStripLabel();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            lblMessages = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            reportImage = new System.Windows.Forms.OpenFileDialog();
            btnOpenFileDialog = new System.Windows.Forms.Button();
            txtMediaName = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            btnClearMedia = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)ReportIssuesNavigator).BeginInit();
            ReportIssuesNavigator.SuspendLayout();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            txtLocation.Location = new System.Drawing.Point(127, 151);
            txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new System.Drawing.Size(284, 27);
            txtLocation.TabIndex = 0;
            // 
            // lstCategory
            // 
            lstCategory.FormattingEnabled = true;
            lstCategory.Items.AddRange(new object[] { "Sanitation", "Road", "Utilities" });
            lstCategory.Location = new System.Drawing.Point(127, 210);
            lstCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lstCategory.Name = "lstCategory";
            lstCategory.Size = new System.Drawing.Size(284, 64);
            lstCategory.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(127, 304);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(284, 155);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(47, 151);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Location:";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 29);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(43, 308);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Description:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            btnSubmit.Location = new System.Drawing.Point(373, 608);
            btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ReportIssuesNavigator
            // 
            ReportIssuesNavigator.AddNewItem = null;
            ReportIssuesNavigator.CountItem = null;
            ReportIssuesNavigator.DeleteItem = null;
            ReportIssuesNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            ReportIssuesNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { sep, toolStripDropDownButton1, toolStripSeparator2, lblRefreshQuote, toolStripSeparator1, lblFeedback, toolStripSeparator3 });
            ReportIssuesNavigator.Location = new System.Drawing.Point(0, 0);
            ReportIssuesNavigator.MoveFirstItem = null;
            ReportIssuesNavigator.MoveLastItem = null;
            ReportIssuesNavigator.MoveNextItem = null;
            ReportIssuesNavigator.MovePreviousItem = null;
            ReportIssuesNavigator.Name = "ReportIssuesNavigator";
            ReportIssuesNavigator.PositionItem = null;
            ReportIssuesNavigator.Size = new System.Drawing.Size(801, 27);
            ReportIssuesNavigator.TabIndex = 7;
            ReportIssuesNavigator.Text = "bindingNavigator1";
            // 
            // sep
            // 
            sep.Name = "sep";
            sep.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { drpMainMenu, drpEvents, drpReq });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(65, 24);
            toolStripDropDownButton1.Text = "Go To:";
            // 
            // drpMainMenu
            // 
            drpMainMenu.Name = "drpMainMenu";
            drpMainMenu.Size = new System.Drawing.Size(314, 26);
            drpMainMenu.Text = "Main Menu";
            drpMainMenu.Click += drpMainMenu_Click;
            // 
            // drpEvents
            // 
            drpEvents.Name = "drpEvents";
            drpEvents.Size = new System.Drawing.Size(314, 26);
            drpEvents.Text = "Local Events And Announcements";
            drpEvents.Click += drpEvents_Click;
            // 
            // drpReq
            // 
            drpReq.Enabled = false;
            drpReq.Name = "drpReq";
            drpReq.Size = new System.Drawing.Size(314, 26);
            drpReq.Text = "Service Request Status";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // lblRefreshQuote
            // 
            lblRefreshQuote.Name = "lblRefreshQuote";
            lblRefreshQuote.Size = new System.Drawing.Size(84, 24);
            lblRefreshQuote.Text = "New Quote";
            lblRefreshQuote.Click += lblRefreshQuote_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // lblFeedback
            // 
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new System.Drawing.Size(109, 24);
            lblFeedback.Text = "Send Feedback";
            lblFeedback.Click += lblFeedback_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // lblMessages
            // 
            lblMessages.AutoSize = true;
            lblMessages.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblMessages.Location = new System.Drawing.Point(419, 210);
            lblMessages.Name = "lblMessages";
            lblMessages.Size = new System.Drawing.Size(0, 22);
            lblMessages.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(43, 210);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 20);
            label4.TabIndex = 10;
            label4.Text = "Category:";
            // 
            // reportImage
            // 
            reportImage.FileName = "openFileDialog1";
            reportImage.Filter = "All Files |*.jpg;*.jpeg;*.png;*.doc;*.xls;*.ppt";
            reportImage.Title = "Browse Files";
            // 
            // btnOpenFileDialog
            // 
            btnOpenFileDialog.Location = new System.Drawing.Point(127, 484);
            btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnOpenFileDialog.Name = "btnOpenFileDialog";
            btnOpenFileDialog.Size = new System.Drawing.Size(123, 42);
            btnOpenFileDialog.TabIndex = 11;
            btnOpenFileDialog.Text = "Browse Files";
            btnOpenFileDialog.UseVisualStyleBackColor = true;
            btnOpenFileDialog.Click += btnOpenFileDialog_Click;
            // 
            // txtMediaName
            // 
            txtMediaName.Location = new System.Drawing.Point(127, 535);
            txtMediaName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMediaName.Name = "txtMediaName";
            txtMediaName.ReadOnly = true;
            txtMediaName.Size = new System.Drawing.Size(284, 27);
            txtMediaName.TabIndex = 12;
            txtMediaName.Text = "None";
            txtMediaName.Click += txtSelectedMedia_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(32, 542);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 20);
            label5.TabIndex = 13;
            label5.Text = "Selected File:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(417, 151);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(358, 35);
            label6.TabIndex = 14;
            label6.Text = "Words of Encouragement:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(182, 59);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(430, 42);
            label7.TabIndex = 15;
            label7.Text = "REPORT YOUR ISSUE";
            // 
            // btnClearMedia
            // 
            btnClearMedia.Location = new System.Drawing.Point(256, 485);
            btnClearMedia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClearMedia.Name = "btnClearMedia";
            btnClearMedia.Size = new System.Drawing.Size(155, 42);
            btnClearMedia.TabIndex = 16;
            btnClearMedia.Text = "Clear Selected File";
            btnClearMedia.UseVisualStyleBackColor = true;
            btnClearMedia.Click += btnClearMedia_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label8.Location = new System.Drawing.Point(42, 518);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(75, 20);
            label8.TabIndex = 17;
            label8.Text = "(optional)";
            // 
            // Report_Issues_Page
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            ClientSize = new System.Drawing.Size(801, 691);
            Controls.Add(ReportIssuesNavigator);
            Controls.Add(label8);
            Controls.Add(btnClearMedia);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtMediaName);
            Controls.Add(btnOpenFileDialog);
            Controls.Add(label4);
            Controls.Add(lblMessages);
            Controls.Add(btnSubmit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(lstCategory);
            Controls.Add(txtLocation);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Report_Issues_Page";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Report Issues";
            ((System.ComponentModel.ISupportInitialize)ReportIssuesNavigator).EndInit();
            ReportIssuesNavigator.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.BindingNavigator ReportIssuesNavigator;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.ToolStripSeparator sep;
        private System.Windows.Forms.ToolStripLabel lblRefreshQuote;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem drpMainMenu;
        private System.Windows.Forms.ToolStripMenuItem drpEvents;
        private System.Windows.Forms.ToolStripMenuItem drpReq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog reportImage;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.TextBox txtMediaName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripLabel lblFeedback;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearMedia;
        private System.Windows.Forms.Label label8;
    }
}