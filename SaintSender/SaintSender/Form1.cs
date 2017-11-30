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

        private void MailForm_Load(object sender, EventArgs e)
        {
            APIHandler api = new APIHandler();
            Populator populator = new Populator();

            populator.Populate(InboxMessages, "INBOX");
            populator.Populate(SocialMessages, "CATEGORY_SOCIAL");
            populator.Populate(PromoMessages, "CATEGORY_PROMOTIONS");

        }
    }
}
