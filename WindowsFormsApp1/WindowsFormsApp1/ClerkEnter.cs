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
    public partial class ClerkEnter : Form
    {
        DbClass db = new DbClass();
        public ClerkEnter()
        {
            InitializeComponent();
        }

        private void clerkloginbutton_Click(object sender, EventArgs e)
        {
           
            if (db.CheckBankClerkTableIsExist() == false)
            {
                db.createBankClerkTable();
            }
            string clerkid = this.ClerkIdTextBox.Text.Trim();
            string passwd = this.ClerkpasswdTextBox.Text.Trim();
            if (clerkid != null && passwd != null)
            {
                if (db.CheckBank(clerkid,passwd) == true)
                {
                    ClerkInfoClass.ClerkName=db.queryclerkname(clerkid, passwd);
                    ClerkInfoClass.ClerkID = clerkid;
                    MessageBox.Show("Welcom："+ClerkInfoClass.ClerkName+"\n"+"ID:"+ClerkInfoClass.ClerkID+"\nEnter System！");
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                    
                }
                else
                {
                    this.ClerkIdTextBox.Clear();
                    this.ClerkpasswdTextBox.Clear();
                    this.ClerkIdTextBox.Focus();
                    MessageBox.Show("ERROR Incorrect username or password");
                }
            }
        }

        private void clerklogoutbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClerkEnter_Load(object sender, EventArgs e)
        {
            db.createTable();
            db.createBankClerkTable();
            db.createRecordTable();
            int rid = 1;
            string account = "waiting";
            string name = "waiting";
            string operation = "Start";
            db.startinsertinotRecord(rid,name,account,operation);
        }
    }
}
