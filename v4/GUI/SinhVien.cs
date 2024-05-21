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
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            cbMaNganh.DataSource = DataAccess.getList("select distinct(manganh) from nganhhoc");
            string query = "select\n" +
                           "case\n" +
                           "when sv.TinhTrang = 0 then N'Đang theo học'\n" +
                           "when sv.TinhTrang = 1 then N'Đang bảo lưu'\n" +
                           "when sv.TinhTrang = 2 then N'Thôi học'\n" +
                           "end as TinhTrangHienTai\n" +
                           "from SinhVien sv";
            cbTinhTrang.DataSource = DataAccess.getList(query);
            string sql = "select * from SinhVien";
            dgvSV.DataSource = DataAccess.getData(sql);
        }

    }
}
