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
    public partial class HocPhanTheoNganh : Form
    {
        public HocPhanTheoNganh()
        {
            InitializeComponent();
        }

        private void HocPhanTheoNganh_Load(object sender, EventArgs e)
        {
            cbMaNganh.DataSource = DataAccess.getList("select distinct(manganh) from NganhHoc");
            
            string sql = "select * from hocphantheonganh";
            dgvHPTN.DataSource = DataAccess.getData(sql);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
