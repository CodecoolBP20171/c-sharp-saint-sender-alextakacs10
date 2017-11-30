namespace SaintSender
{
    partial class MailForm
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.RefreshMessage = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MailBody = new System.Windows.Forms.RichTextBox();
            this.InboxMessages = new System.Windows.Forms.ListView();
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllMessagesTab = new System.Windows.Forms.TabControl();
            this.PrimaryTab = new System.Windows.Forms.TabPage();
            this.SocialTab = new System.Windows.Forms.TabPage();
            this.SocialMessages = new System.Windows.Forms.ListView();
            this.SocialSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SocialFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PromoTab = new System.Windows.Forms.TabPage();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.PromoMessages = new System.Windows.Forms.ListView();
            this.PromoSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PromoFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllMessagesTab.SuspendLayout();
            this.PrimaryTab.SuspendLayout();
            this.SocialTab.SuspendLayout();
            this.PromoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(809, 11);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 25);
            this.RefreshButton.TabIndex = 0;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // RefreshMessage
            // 
            this.RefreshMessage.AutoSize = true;
            this.RefreshMessage.Location = new System.Drawing.Point(641, 17);
            this.RefreshMessage.Name = "RefreshMessage";
            this.RefreshMessage.Size = new System.Drawing.Size(162, 13);
            this.RefreshMessage.TabIndex = 1;
            this.RefreshMessage.Text = "Updated at 28-11-2017 11:35:25";
            this.RefreshMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(13, 14);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(300, 20);
            this.SearchBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(319, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 25);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // MailBody
            // 
            this.MailBody.Location = new System.Drawing.Point(348, 89);
            this.MailBody.Name = "MailBody";
            this.MailBody.Size = new System.Drawing.Size(536, 348);
            this.MailBody.TabIndex = 0;
            this.MailBody.Text = "";
            // 
            // InboxMessages
            // 
            this.InboxMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Subject,
            this.MessageID});
            this.InboxMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InboxMessages.FullRowSelect = true;
            this.InboxMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.InboxMessages.Location = new System.Drawing.Point(3, 3);
            this.InboxMessages.MultiSelect = false;
            this.InboxMessages.Name = "InboxMessages";
            this.InboxMessages.Size = new System.Drawing.Size(315, 338);
            this.InboxMessages.TabIndex = 4;
            this.InboxMessages.UseCompatibleStateImageBehavior = false;
            this.InboxMessages.View = System.Windows.Forms.View.Details;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 107;
            // 
            // MessageID
            // 
            this.MessageID.Text = "ID";
            this.MessageID.Width = 186;
            // 
            // AllMessagesTab
            // 
            this.AllMessagesTab.Controls.Add(this.PrimaryTab);
            this.AllMessagesTab.Controls.Add(this.SocialTab);
            this.AllMessagesTab.Controls.Add(this.PromoTab);
            this.AllMessagesTab.Controls.Add(this.UpdateTab);
            this.AllMessagesTab.Location = new System.Drawing.Point(13, 67);
            this.AllMessagesTab.Name = "AllMessagesTab";
            this.AllMessagesTab.SelectedIndex = 0;
            this.AllMessagesTab.Size = new System.Drawing.Size(329, 370);
            this.AllMessagesTab.TabIndex = 5;
            // 
            // PrimaryTab
            // 
            this.PrimaryTab.Controls.Add(this.InboxMessages);
            this.PrimaryTab.Location = new System.Drawing.Point(4, 22);
            this.PrimaryTab.Name = "PrimaryTab";
            this.PrimaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.PrimaryTab.Size = new System.Drawing.Size(321, 344);
            this.PrimaryTab.TabIndex = 0;
            this.PrimaryTab.Text = "Primary";
            this.PrimaryTab.UseVisualStyleBackColor = true;
            // 
            // SocialTab
            // 
            this.SocialTab.Controls.Add(this.SocialMessages);
            this.SocialTab.Location = new System.Drawing.Point(4, 22);
            this.SocialTab.Name = "SocialTab";
            this.SocialTab.Padding = new System.Windows.Forms.Padding(3);
            this.SocialTab.Size = new System.Drawing.Size(321, 344);
            this.SocialTab.TabIndex = 1;
            this.SocialTab.Text = "Social";
            this.SocialTab.UseVisualStyleBackColor = true;
            // 
            // SocialMessages
            // 
            this.SocialMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SocialSubject,
            this.SocialFrom});
            this.SocialMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SocialMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.SocialMessages.Location = new System.Drawing.Point(3, 3);
            this.SocialMessages.Name = "SocialMessages";
            this.SocialMessages.Size = new System.Drawing.Size(315, 338);
            this.SocialMessages.TabIndex = 0;
            this.SocialMessages.UseCompatibleStateImageBehavior = false;
            this.SocialMessages.View = System.Windows.Forms.View.Details;
            // 
            // SocialSubject
            // 
            this.SocialSubject.Text = "Subject";
            // 
            // SocialFrom
            // 
            this.SocialFrom.Text = "From";
            // 
            // PromoTab
            // 
            this.PromoTab.Controls.Add(this.PromoMessages);
            this.PromoTab.Location = new System.Drawing.Point(4, 22);
            this.PromoTab.Name = "PromoTab";
            this.PromoTab.Padding = new System.Windows.Forms.Padding(3);
            this.PromoTab.Size = new System.Drawing.Size(321, 344);
            this.PromoTab.TabIndex = 2;
            this.PromoTab.Text = "Promotions";
            this.PromoTab.UseVisualStyleBackColor = true;
            // 
            // UpdateTab
            // 
            this.UpdateTab.Location = new System.Drawing.Point(4, 22);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTab.Size = new System.Drawing.Size(321, 344);
            this.UpdateTab.TabIndex = 3;
            this.UpdateTab.Text = "Updates";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // PromoMessages
            // 
            this.PromoMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PromoSubject,
            this.PromoFrom});
            this.PromoMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PromoMessages.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.PromoMessages.Location = new System.Drawing.Point(3, 3);
            this.PromoMessages.Name = "PromoMessages";
            this.PromoMessages.Size = new System.Drawing.Size(315, 338);
            this.PromoMessages.TabIndex = 0;
            this.PromoMessages.UseCompatibleStateImageBehavior = false;
            this.PromoMessages.View = System.Windows.Forms.View.Details;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 517);
            this.Controls.Add(this.AllMessagesTab);
            this.Controls.Add(this.MailBody);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.RefreshMessage);
            this.Controls.Add(this.RefreshButton);
            this.Name = "MailForm";
            this.Text = "SaintSender";
            this.Load += new System.EventHandler(this.MailForm_Load);
            this.AllMessagesTab.ResumeLayout(false);
            this.PrimaryTab.ResumeLayout(false);
            this.SocialTab.ResumeLayout(false);
            this.PromoTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label RefreshMessage;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RichTextBox MailBody;
        private System.Windows.Forms.ListView InboxMessages;
        private System.Windows.Forms.TabControl AllMessagesTab;
        private System.Windows.Forms.TabPage PrimaryTab;
        private System.Windows.Forms.TabPage SocialTab;
        private System.Windows.Forms.TabPage PromoTab;
        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader MessageID;
        private System.Windows.Forms.ListView SocialMessages;
        private System.Windows.Forms.ColumnHeader SocialSubject;
        private System.Windows.Forms.ColumnHeader SocialFrom;
        private System.Windows.Forms.ListView PromoMessages;
        private System.Windows.Forms.ColumnHeader PromoSubject;
        private System.Windows.Forms.ColumnHeader PromoFrom;
    }
}

