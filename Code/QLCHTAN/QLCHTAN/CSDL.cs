using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAO;
using System.Data.Sql;

namespace QLCHTAN
{
    public partial class CSDL : Form
    {
        getServer myServer = new getServer();
        public CSDL()
        {
            InitializeComponent();
            
        }
        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (ccbDataSource.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Tên server không được để trống");
                return;
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    conn.ConnectionString = @"Data Source=" + ccbDataSource.SelectedValue.ToString() + ";Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=123";
                    conn.Open();
                    MessageBox.Show("Kết nối server thành công");
                    SqlCommand cmd = new SqlCommand(" SELECT name FROM sys.master_files WHERE name='QLCUAHANGTHUCANNHANH'", conn);
                    var kt = cmd.ExecuteScalar();
                    if (kt != null)
                        try
                        {
                            DataProvider.DataSource = ccbDataSource.SelectedValue.ToString();
                            DataProvider dataProvider = new DataProvider();   
                            dataProvider.Open();
                            MessageBox.Show("Kết nối thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Không thể kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                    {
                        MessageBox.Show("Không thể kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CSDL_Load(object sender, EventArgs e)
        {
           ccbDataSource.DataSource= myServer.GetServerNameFromPC();
        }
    }
}
