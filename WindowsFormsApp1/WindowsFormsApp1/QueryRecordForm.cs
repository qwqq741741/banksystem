using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class QueryRecordForm : Form
    {
        public QueryRecordForm()
        {
            InitializeComponent();
        }

        private void QueryRecordForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strConnection = "Integrated Security=SSPI;Initial Catalog=bank1;Data Source=YLMF-1611271519;User ID=YLMF-1611271519\\Administrator;";
            //string strConnection = "server =.\\SQLEXPRESS;Initial catalog=bank1;Integrated security = SSPI";
            string sql = string.Format("use bank1 SELECT * FROM  dbo.Record; ");
            using (SqlConnection objConnection = new SqlConnection(strConnection))
            {

                try
                {
                    objConnection.Open();
                    SqlCommand cmd = new SqlCommand(sql, objConnection);
                    cmd.Connection = objConnection;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    this.dataGridView1.DataSource = ds.Tables[0];
                    objConnection.Close();
                    objConnection.Dispose();
                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
