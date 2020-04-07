using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyKsan
{
    public partial class FrmQLyKsan : Form
    {
        SqlConnection con = new SqlConnection();
        public FrmQLyKsan()
        {
            InitializeComponent();
        }

        private void FrmQLyKsan_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=ADMIN;Initial Catalog=QLyKhachSan;Integrated Security=True";
            con.ConnectionString = connectionstring;
            con.Open();

            loadDataToGridview();


        }
        private void  loadDataToGridview()
        {
            string sql = " Select * from tblPhong";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tabletblPhong = new DataTable();
            adp.Fill(tabletblPhong);

            DataGidView_tblPhong.DataSource = tabletblPhong;
        }

        private void DataGritView_tblPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDonGia.Text = DataGidView_tblPhong.CurrentRow.Cells["don gia"].Value.ToString();
            txtMaPhong.Text = DataGidView_tblPhong.CurrentRow.Cells["ma phong"].Value.ToString();
            txtTenPhong.Text = DataGidView_tblPhong.CurrentRow.Cells["ten phong"].Value.ToString();
            txtMaPhong.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete From tblPhong Where MaPhong= '" + txtTenPhong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            loadDataToGridview();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtTenPhong.Text  = "";
            txtMaPhong.Text = "";
            txtDonGia.Text = "";
            txtMaPhong.Enabled = true;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("ban can nhap ma phong");
                txtMaPhong.Focus();
                return;
            }
            if (txtTenPhong.Text == "")
            {
                MessageBox.Show("ban can nhap ten phong");
                txtTenPhong.Focus();
                return;
            }
            else
            {
                string sql = "insert into tblPhong values ('" + txtMaPhong.Text + "','" + txtTenPhong.Text + "'";
                if (txtDonGia.Text != "")
                    sql = sql + "," + txtDonGia.Text.Trim();
                sql = sql + ")";

                try
                {

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery ();

                    loadDataToGridview();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex. ToString());

                }
                return;
            }
           
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >= '0') && (e.KeyChar <= '9'))||
                (Convert .ToInt32 (e.KeyChar )==8 )|| (Convert .ToInt32 (e.KeyChar )==13))
                {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            con.Close ();
            this.Close();
           
        }
    }
}
