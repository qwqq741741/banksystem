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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginaccountbutton_Click(object sender, EventArgs e)
        {
            DbClass db = new DbClass();
            if (db.CheckTableIsExist() == false) {
                db.createTable();
            }
            LoginAccountForm loginAccountForm = new LoginAccountForm();
            loginAccountForm.Show();
            this.Hide();
        }

        private void tuichubutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void querymoneybutton_Click(object sender, EventArgs e)
        {
            QueryForm qf = new QueryForm();
            this.Hide();
            qf.Show();
        }

        private void addmoneybutton_Click(object sender, EventArgs e)
        {
            AddMoneyForm am = new AddMoneyForm();
            this.Hide();
            am.Show();
        }

        private void getmoneybutton_Click(object sender, EventArgs e)
        {
            DrawMoneyForm drawMoneyForm = new DrawMoneyForm();
            this.Hide();
            drawMoneyForm.Show();
        }

        private void delaccountbutton_Click(object sender, EventArgs e)
        {
            DeleteAccountForm deleteAccountForm = new DeleteAccountForm();
            deleteAccountForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbClass db = new DbClass();
            db.createTable();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            QueryRecordForm queryRecordForm = new QueryRecordForm();
            this.Hide();
            queryRecordForm.Show();
        }
    }
}
