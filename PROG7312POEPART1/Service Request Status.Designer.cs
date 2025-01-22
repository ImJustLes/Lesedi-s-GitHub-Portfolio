namespace PROG7312POEPART1
{
    partial class Service_Request_Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service_Request_Status));
            label4 = new System.Windows.Forms.Label();
            btnTrack = new System.Windows.Forms.Button();
            lstServices = new System.Windows.Forms.ListBox();
            lstTrackedServices = new System.Windows.Forms.ListBox();
            label6 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.RichTextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            drpNavigator = new System.Windows.Forms.ToolStripDropDownButton();
            btn_mainmenu = new System.Windows.Forms.ToolStripMenuItem();
            btn_report = new System.Windows.Forms.ToolStripMenuItem();
            btn_events = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            lblSendFeedback = new System.Windows.Forms.ToolStripLabel();
            btnExit = new System.Windows.Forms.Button();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(206, 70);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(552, 42);
            label4.TabIndex = 9;
            label4.Text = "SERVICE REQUEST STATUS";
            // 
            // btnTrack
            // 
            btnTrack.BackColor = System.Drawing.Color.DarkOrange;
            btnTrack.Location = new System.Drawing.Point(133, 383);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new System.Drawing.Size(231, 29);
            btnTrack.TabIndex = 10;
            btnTrack.Text = "Track";
            btnTrack.UseVisualStyleBackColor = false;
            btnTrack.Click += btnTrack_Click;
            // 
            // lstServices
            // 
            lstServices.FormattingEnabled = true;
            lstServices.Location = new System.Drawing.Point(71, 176);
            lstServices.Name = "lstServices";
            lstServices.Size = new System.Drawing.Size(354, 184);
            lstServices.TabIndex = 11;
            lstServices.SelectedIndexChanged += lstServices_SelectedIndexChanged;
            // 
            // lstTrackedServices
            // 
            lstTrackedServices.FormattingEnabled = true;
            lstTrackedServices.Location = new System.Drawing.Point(539, 176);
            lstTrackedServices.Name = "lstTrackedServices";
            lstTrackedServices.Size = new System.Drawing.Size(353, 184);
            lstTrackedServices.TabIndex = 12;
            lstTrackedServices.SelectedIndexChanged += lstTrackedServices_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(71, 134);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(128, 35);
            label6.TabIndex = 18;
            label6.Text = "Services:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(539, 134);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(239, 35);
            label1.TabIndex = 19;
            label1.Text = "Tracked Services:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(426, 443);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 35);
            label2.TabIndex = 21;
            label2.Text = "Details:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(261, 482);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new System.Drawing.Size(469, 142);
            txtDescription.TabIndex = 20;
            txtDescription.Text = "";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { drpNavigator, toolStripSeparator1, lblSendFeedback });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(984, 27);
            toolStrip1.TabIndex = 22;
            toolStrip1.Text = "toolStrip1";
            // 
            // drpNavigator
            // 
            drpNavigator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            drpNavigator.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_mainmenu, btn_report, btn_events });
            drpNavigator.Image = (System.Drawing.Image)resources.GetObject("drpNavigator.Image");
            drpNavigator.ImageTransparentColor = System.Drawing.Color.Magenta;
            drpNavigator.Name = "drpNavigator";
            drpNavigator.Size = new System.Drawing.Size(65, 24);
            drpNavigator.Text = "Go To:";
            // 
            // btn_mainmenu
            // 
            btn_mainmenu.Name = "btn_mainmenu";
            btn_mainmenu.Size = new System.Drawing.Size(314, 26);
            btn_mainmenu.Text = "Main Menu";
            btn_mainmenu.Click += btn_mainmenu_Click;
            // 
            // btn_report
            // 
            btn_report.Name = "btn_report";
            btn_report.Size = new System.Drawing.Size(314, 26);
            btn_report.Text = "Report Issue";
            btn_report.Click += btn_report_Click;
            // 
            // btn_events
            // 
            btn_events.Name = "btn_events";
            btn_events.Size = new System.Drawing.Size(314, 26);
            btn_events.Text = "Local Events And Announcements";
            btn_events.Click += btn_events_Click;
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
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.Red;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnExit.Location = new System.Drawing.Point(802, 572);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(149, 52);
            btnExit.TabIndex = 24;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Service_Request_Status
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            ClientSize = new System.Drawing.Size(984, 676);
            Controls.Add(btnExit);
            Controls.Add(toolStrip1);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(lstTrackedServices);
            Controls.Add(lstServices);
            Controls.Add(btnTrack);
            Controls.Add(label4);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Service_Request_Status";
            Text = "Service Request Status";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.ListBox lstTrackedServices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton drpNavigator;
        private System.Windows.Forms.ToolStripMenuItem btn_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem btn_report;
        private System.Windows.Forms.ToolStripMenuItem btn_events;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblSendFeedback;
        private System.Windows.Forms.Button btnExit;
    }
}