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

        public void cust_info()
        {
            string name = cust_name.Text;
            string tel = cust_tel1.Text + cust_tel2.Text + cust_tel3;
            string gender = cust_gender.Text;
            string birth = cust_birth.Text;
            string address = cust_address.Text;
            string regi_date = cust_regi_date.Text;
            string expire_date = cust_expire_date.Text;
        }
    }
}
