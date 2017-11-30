using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_Load (object sender, EventArgs e)
        {
            PopulateTabs();
        }

        private async void PopulateTabs()
        {
            APIHandler api = new APIHandler();
            Populator populator = new Populator();

            var inboxMessages = await populator.Populate("INBOX");
            var socialMessages = await populator.Populate("CATEGORY_SOCIAL");
            var promoMessages = await populator.Populate("CATEGORY_PROMOTIONS");
            InboxWaitLabel.Visible = false;

            foreach (var objectToAdd in inboxMessages)
            {
                InboxMessages.Items.Add(new ListViewItem(objectToAdd));
            }
        }
    }
}
