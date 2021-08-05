using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gymManagement.ui
{
    public partial class CusRegi : Form
    {
        public CusRegi()
        {
            InitializeComponent();
        }

        public void cus_info()
        {
            string name = cust_name.Text;
            string tel = cust_tel1.Text + cust_tel2.Text + cust_tel3;
            string gender;
            string birth;
            string address;
            string regi_date;
            string expire_date;

        }
    }
}
