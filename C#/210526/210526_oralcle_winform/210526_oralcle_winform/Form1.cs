using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data.OleDb;

namespace _210526_oralcle_winform
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                //아래 onj는 $ORACLE_HOME/network/admin에 있는 tnsnames.ora 파읷에 정의된 이름!
                string conStr = "Provider=OraOLEDB.Oracle;data source=XE;User ID=sqlDB;Password=1234";
                conn = new OleDbConnection(conStr);
                conn.Open();
                adapter = new OleDbDataAdapter("select * from buyTBL", conn);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO buyTBL "
            conn.Open();

        }
    }
}
