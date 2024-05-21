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
    public partial class HocPhan : Form
    {
        public HocPhan()
        {
            InitializeComponent();
        }

        private void HocPhan_Load(object sender, EventArgs e)
        {
            cbMaKhoa.DataSource = DataAccess.getList("select distinct(makhoa) from Khoa");
            string query = "select\n" +
                           "case\n" +
                           "when hp.LoaiHocPhan = 0 then N'Lý thuyết'\n" +
                           "when hp.LoaiHocPhan = 1 then N'Thực hành'\n" +
                           "end as loaiHocPhan\n" +
                           "from HocPhan hp";
            cbLoaiHocPhan.DataSource = DataAccess.getList(query);
            string sql = "select * from hocphan";
            dgvHP.DataSource = DataAccess.getData(sql);
        }
    }
}
