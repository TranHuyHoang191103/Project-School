using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LopHocPhan : Form
    {
        public LopHocPhan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LopHocPhan_Load(object sender, EventArgs e)
        {
            cbMaHP.DataSource = DataAccess.getList("select distinct(mahocphan) from HocPhan");
            cbMaLop.DataSource = DataAccess.getList("select distinct(malop) from lophoc");

            string sql = "select * from lophocphan";
            dgvLopHP.DataSource = DataAccess.getData(sql);
        }
    }
}
