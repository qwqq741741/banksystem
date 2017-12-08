using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DeleteAccountForm : Form
    {
        public DeleteAccountForm()
        {
            InitializeComponent();
        }

        private void LoginAccounOKButton_Click(object sender, EventArgs e)
        {
            string name = this.deleteAccountTextBox.Text.Trim();
            string passwd = this.deleteAccountPasswd.Text.Trim();
            DbClass dbClass = new DbClass();
            if (dbClass.CheckUser(name) == false)
            {
                MessageBox.Show("The account does not exist, please retype!");
            }
            else
            {
                dbClass.deleteAccount(name, passwd);
                string operation = "Delete account：" + name;
                int rid = dbClass.getmaxrid() + 1;
                dbClass.insertinotRecord(rid, ClerkInfoClass.ClerkID,name, operation);
                MessageBox.Show("Account destruction success!");
            }
        }

        private void deleteAccountCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm form1 = new MainForm();
            form1.Show();
        }
    }
}
