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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "select MaNganh from NganhHoc";
            cbMaNganh.DataSource = DataAccess.getList(query);

            string sql = "select * from LopHoc";
            dgvLopHoc.DataSource = DataAccess.getData(sql);
        }
    }
}