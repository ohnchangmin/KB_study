using gymManagement.controller;
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
    public partial class TrainerMgr : Form
    {
        OraController orc = new OraController();
        Adapter ad = new Adapter(orc);
        public TrainerMgr()
        {
            InitializeComponent();
        }

        private void TrainerMgr_Load(object sender, EventArgs e)
        {
            
        }
    }
}
