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
            txtDescription.Location = new System.Drawing.Point(589, 285);
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
            lstSearchResults.Location = new System.Drawing.Point(90, 238);
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
            label6.Location = new System.Drawing.Point(84, 185);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(116, 35);
            label6.TabIndex = 17;
            label6.Text = "Results:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(589, 232);
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
            serviceRequestStatusToolStripMenuItem.Enabled = false;
            serviceRequestStatusToolStripMenuItem.Name = "serviceRequestStatusToolStripMenuItem";
            serviceRequestStatusToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            serviceRequestStatusToolStripMenuItem.Text = "Service Request Status";
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
            label3.Location = new System.Drawing.Point(84, 436);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(219, 35);
            label3.TabIndex = 21;
            label3.Text = "Recommended:";
            // 
            // lstRecommendations
            // 
            lstRecommendations.FormattingEnabled = true;
            lstRecommendations.Location = new System.Drawing.Point(90, 474);
            lstRecommendations.Name = "lstRecommendations";
            lstRecommendations.Size = new System.Drawing.Size(375, 124);
            lstRecommendations.TabIndex = 22;
            // 
            // LocalEventsAndAnnouncements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            ClientSize = new System.Drawing.Size(915, 731);
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
    }
}