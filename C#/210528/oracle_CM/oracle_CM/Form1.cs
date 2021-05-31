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

namespace oracle_CM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = null;
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            string conStr = "Provider=OraOLEDB.Oracle; data source=XE; User ID=HEALTH; Password=1234";
            conn = new OleDbConnection(conStr);

        }

        
        //회원등록
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT"
            conn.Open();
            adapter = new OleDbDataAdapter(sql, conn);
        }
       
        //회원조회
        private void button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}
