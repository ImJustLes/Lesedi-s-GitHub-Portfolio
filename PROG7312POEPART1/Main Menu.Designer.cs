namespace PROG7312POEPART1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_report = new System.Windows.Forms.Button();
            btnFeedback = new System.Windows.Forms.Button();
            gbButtons = new System.Windows.Forms.GroupBox();
            btn_req = new System.Windows.Forms.Button();
            btn_events = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            gbButtons.SuspendLayout();
            SuspendLayout();
            // 
            // btn_report
            // 
            btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btn_report.Location = new System.Drawing.Point(241, 175);
            btn_report.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_report.Name = "btn_report";
            btn_report.Size = new System.Drawing.Size(314, 60);
            btn_report.TabIndex = 3;
            btn_report.Text = "Report Issues";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click_1;
            // 
            // btnFeedback
            // 
            btnFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnFeedback.Location = new System.Drawing.Point(241, 398);
            btnFeedback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new System.Drawing.Size(314, 59);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "Send Feedback";
            btnFeedback.UseVisualStyleBackColor = true;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // gbButtons
            // 
            gbButtons.Controls.Add(btn_req);
            gbButtons.Location = new System.Drawing.Point(241, 322);
            gbButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbButtons.Name = "gbButtons";
            gbButtons.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gbButtons.Size = new System.Drawing.Size(314, 68);
            gbButtons.TabIndex = 5;
            gbButtons.TabStop = false;
            gbButtons.Text = "COMING SOON...";
            // 
            // btn_req
            // 
            btn_req.Enabled = false;
            btn_req.Location = new System.Drawing.Point(0, 26);
            btn_req.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_req.Name = "btn_req";
            btn_req.Size = new System.Drawing.Size(314, 29);
            btn_req.TabIndex = 3;
            btn_req.Text = "Service Request Status";
            btn_req.UseVisualStyleBackColor = true;
            // 
            // btn_events
            // 
            btn_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            btn_events.Location = new System.Drawing.Point(241, 254);
            btn_events.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btn_events.Name = "btn_events";
            btn_events.Size = new System.Drawing.Size(314, 60);
            btn_events.TabIndex = 4;
            btn_events.Text = "Local Events and Announcements";
            btn_events.UseVisualStyleBackColor = true;
            btn_events.Click += btn_events_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(277, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(239, 42);
            label4.TabIndex = 9;
            label4.Text = "MAIN MENU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(btn_events);
            Controls.Add(label4);
            Controls.Add(gbButtons);
            Controls.Add(btnFeedback);
            Controls.Add(btn_report);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Main Menu";
            gbButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btn_events;
        private System.Windows.Forms.Button btn_req;
        private System.Windows.Forms.Label label4;
    }
}

