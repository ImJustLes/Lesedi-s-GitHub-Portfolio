namespace PROG7312POEPART1
{
    partial class LocalEventsAndAnnouncements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalEventsAndAnnouncements));
            imageList1 = new System.Windows.Forms.ImageList(components);
            txtDescription = new System.Windows.Forms.RichTextBox();
            lstSearchResults = new System.Windows.Forms.ListBox();
            txtSearch = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            lblSendFeedback = new System.Windows.Forms.ToolStripLabel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            drpNavigator = new System.Windows.Forms.ToolStripDropDownButton();
            mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serviceRequestStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lstRecommendations = new System.Windows.Forms.ListBox();
            btnExit = new System.Windows.Forms.Button();
            dtpStartDate = new System.Windows.Forms.DateTimePicker();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            dtpEndDate = new System.Windows.Forms.DateTimePicker();
            process1 = new System.Diagnostics.Process();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageSize = new System.Drawing.Size(16, 16);
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(589, 359);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new System.Drawing.Size(213, 277);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            // 
            // lstSearchResults
            // 
            lstSearchResults.FormattingEnabled = true;
            lstSearchResults.Location = new System.Drawing.Point(90, 312);
            lstSearchResults.Name = "lstSearchResults";
            lstSearchResults.Size = new System.Drawing.Size(375, 164);
            lstSearchResults.TabIndex = 3;
            lstSearchResults.SelectedIndexChanged += lstSearchResults_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(152, 141);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(571, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(84, 52);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(775, 42);
            label7.TabIndex = 16;
            label7.Text = "LOCAL EVENTS AND ANNOUNCEMENTS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(84, 259);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(116, 35);
            label6.TabIndex = 17;
            label6.Text = "Results:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(589, 306);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 35);
            label1.TabIndex = 18;
            label1.Text = "Details:";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // lblSendFeedback
            // 
            lblSendFeedback.Name = "lblSendFeedback";
            lblSendFeedback.Size = new System.Drawing.Size(109, 24);
            lblSendFeedback.Text = "Send Feedback";
            lblSendFeedback.Click += lblSendFeedback_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { drpNavigator, toolStripSeparator1, lblSendFeedback });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(915, 27);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // drpNavigator
            // 
            drpNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            drpNavigator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mainMenuToolStripMenuItem, reportIssueToolStripMenuItem, serviceRequestStatusToolStripMenuItem });
            drpNavigator.Image = (System.Drawing.Image)resources.GetObject("drpNavigator.Image");
            drpNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            drpNavigator.Name = "drpNavigator";
            drpNavigator.Size = new System.Drawing.Size(65, 24);
            drpNavigator.Text = "Go To:";
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            mainMenuToolStripMenuItem.Text = "Main Menu";
            mainMenuToolStripMenuItem.Click += mainMenuToolStripMenuItem_Click;
            // 
            // reportIssueToolStripMenuItem
            // 
            reportIssueToolStripMenuItem.Name = "reportIssueToolStripMenuItem";
            reportIssueToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            reportIssueToolStripMenuItem.Text = "Report Issue";
            reportIssueToolStripMenuItem.Click += reportIssueToolStripMenuItem_Click;
            // 
            // serviceRequestStatusToolStripMenuItem
            // 
            serviceRequestStatusToolStripMenuItem.Name = "serviceRequestStatusToolStripMenuItem";
            serviceRequestStatusToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            serviceRequestStatusToolStripMenuItem.Text = "Service Request Status";
            serviceRequestStatusToolStripMenuItem.Click += serviceRequestStatusToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(90, 144);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 20);
            label2.TabIndex = 20;
            label2.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(84, 510);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(219, 35);
            label3.TabIndex = 21;
            label3.Text = "Recommended:";
            // 
            // lstRecommendations
            // 
            lstRecommendations.FormattingEnabled = true;
            lstRecommendations.Location = new System.Drawing.Point(90, 548);
            lstRecommendations.Name = "lstRecommendations";
            lstRecommendations.Size = new System.Drawing.Size(375, 124);
            lstRecommendations.TabIndex = 22;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Red;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.Location = new System.Drawing.Point(619, 688);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(149, 52);
            btnExit.TabIndex = 23;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new System.Drawing.Point(152, 196);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new System.Drawing.Size(259, 27);
            dtpStartDate.TabIndex = 24;
            dtpStartDate.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(56, 201);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 20);
            label4.TabIndex = 25;
            label4.Text = "Date Range:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(424, 201);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(26, 20);
            label5.TabIndex = 26;
            label5.Text = "To";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new System.Drawing.Point(460, 196);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new System.Drawing.Size(263, 27);
            dtpEndDate.TabIndex = 27;
            dtpEndDate.Value = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // LocalEventsAndAnnouncements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            ClientSize = new System.Drawing.Size(915, 753);
            Controls.Add(dtpEndDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpStartDate);
            Controls.Add(btnExit);
            Controls.Add(lstRecommendations);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtSearch);
            Controls.Add(lstSearchResults);
            Controls.Add(txtDescription);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "LocalEventsAndAnnouncements";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LocalEventsAndAnnouncements";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblSendFeedback;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton drpNavigator;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportIssueToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem serviceRequestStatusToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRecommendations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Diagnostics.Process process1;
    }
}