namespace PROG7312POEPART1
{
    partial class Send_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_Feedback));
            txtLocation = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnSubmit = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.RichTextBox();
            bindingNavigator1 = new System.Windows.Forms.BindingNavigator(components);
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            drpDirectTo = new System.Windows.Forms.ToolStripDropDownButton();
            drpMenu = new System.Windows.Forms.ToolStripMenuItem();
            drpEvents = new System.Windows.Forms.ToolStripMenuItem();
            drpService = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).BeginInit();
            bindingNavigator1.SuspendLayout();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.Location = new System.Drawing.Point(269, 151);
            txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new System.Drawing.Size(302, 27);
            txtLocation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(188, 155);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "Location:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            btnSubmit.Location = new System.Drawing.Point(384, 465);
            btnSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new System.Drawing.Size(75, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(205, 214);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(269, 210);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(302, 27);
            txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(172, 272);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Description:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(259, 272);
            txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(312, 146);
            txtDescription.TabIndex = 2;
            txtDescription.Text = "";
            // 
            // bindingNavigator1
            // 
            bindingNavigator1.AddNewItem = null;
            bindingNavigator1.CountItem = null;
            bindingNavigator1.DeleteItem = null;
            bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripSeparator2, drpDirectTo, toolStripSeparator1 });
            bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            bindingNavigator1.MoveFirstItem = null;
            bindingNavigator1.MoveLastItem = null;
            bindingNavigator1.MoveNextItem = null;
            bindingNavigator1.MovePreviousItem = null;
            bindingNavigator1.Name = "bindingNavigator1";
            bindingNavigator1.PositionItem = null;
            bindingNavigator1.Size = new System.Drawing.Size(800, 27);
            bindingNavigator1.TabIndex = 4;
            bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // drpDirectTo
            // 
            drpDirectTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            drpDirectTo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { drpMenu, drpEvents, drpService });
            drpDirectTo.Image = (System.Drawing.Image)resources.GetObject("drpDirectTo.Image");
            drpDirectTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            drpDirectTo.Name = "drpDirectTo";
            drpDirectTo.Size = new System.Drawing.Size(65, 24);
            drpDirectTo.Text = "Go To:";
            // 
            // drpMenu
            // 
            drpMenu.Name = "drpMenu";
            drpMenu.Size = new System.Drawing.Size(312, 26);
            drpMenu.Text = "Main Menu";
            drpMenu.Click += drpMenu_Click;
            // 
            // drpEvents
            // 
            drpEvents.Enabled = false;
            drpEvents.Name = "drpEvents";
            drpEvents.Size = new System.Drawing.Size(312, 26);
            drpEvents.Text = "Local Events and Announcements";
            drpEvents.Click += drpEvents_Click;
            // 
            // drpService
            // 
            drpService.Enabled = false;
            drpService.Name = "drpService";
            drpService.Size = new System.Drawing.Size(312, 26);
            drpService.Text = "Service Request Status";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(291, 34);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(228, 42);
            label4.TabIndex = 8;
            label4.Text = "FEEDBACK";
            // 
            // Send_Feedback
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(255, 255, 192);
            ClientSize = new System.Drawing.Size(800, 562);
            Controls.Add(label4);
            Controls.Add(bindingNavigator1);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(txtLocation);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Send_Feedback";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Send Feedback";
            ((System.ComponentModel.ISupportInitialize)bindingNavigator1).EndInit();
            bindingNavigator1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripDropDownButton drpDirectTo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem drpMenu;
        private System.Windows.Forms.ToolStripMenuItem drpEvents;
        private System.Windows.Forms.ToolStripMenuItem drpService;
        private System.Windows.Forms.Label label4;
    }
}