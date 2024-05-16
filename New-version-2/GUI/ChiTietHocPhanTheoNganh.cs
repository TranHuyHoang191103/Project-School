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
    public partial class ChiTietHocPhanTheoNganh : Form
    {
        public ChiTietHocPhanTheoNganh()
        {
            InitializeComponent();
        }

        private void ChiTietHocPhanTheoNganh_Load(object sender, EventArgs e)
        {
            cbMaHPTN.DataSource = DataAccess.getList("select distinct(mahocphantheonganh) from HocPhanTheoNganh");
            cbMaHP.DataSource = DataAccess.getList("select distinct(mahocphan) from HocPhan");
            string query = "select\n" +
                           "case\n" +
                           "when ct.BatBuoc = 0 then N'Có'\n" +
                           "when ct.BatBuoc = 1 then N'Không'\n" +
                           "end as CHITIET\n" +
                           "from ChiTietHPTheoNganh ct";
            cbBatBuoc.DataSource = DataAccess.getList(query);
            string sql = "select * from chitietHPtheonganh";
            dgvHP.DataSource = DataAccess.getData(sql);
        }
    }
}