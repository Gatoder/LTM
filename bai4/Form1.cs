using System;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Security;

namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void L_Click(object sender, EventArgs e)
        {
            using (var client = new ImapClient())
            {

                string username = E.Text;
                string Password = P.Text;
                client.Connect("127.0.0.1", 143, SecureSocketOptions.None);
                client.Authenticate(username, Password);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                T.Text = inbox.Count.ToString();
                R.Text = inbox.Recent.ToString();
                listmail.Items.Clear();
                listmail.Columns.Add("Email", 400);
                listmail.Columns.Add("From", 250);
                listmail.Columns.Add("Thời gian", 200);
                listmail.View = View.Details;
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);
                    ListViewItem.ListViewSubItem from = new
                    ListViewItem.ListViewSubItem(name, message.From.ToString());
                    name.SubItems.Add(from);
                    ListViewItem.ListViewSubItem date = new
                    ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());
                    name.SubItems.Add(date);
                    listmail.Items.Add(name);
                }
                client.Disconnect(true);
            }
        }

        private void list_TextChanged(object sender, EventArgs e)
        {

        }
    }
}