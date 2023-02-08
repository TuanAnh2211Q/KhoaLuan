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
namespace QLCHTAN
{
    public partial class BackUp_Restore_GUI : Form
    {
        private SqlConnection conn;
        public SqlCommand cmd;
        private SqlDataReader dr;
        string sql="";
        string connStr = "";

        getServer getServer = new getServer();

        public BackUp_Restore_GUI()
        {
            InitializeComponent();
        }

        private void BackUp_Restore_GUI_Load(object sender, EventArgs e)
        {
            cbbTenServer.DataSource = getServer.GetServerNameFromPC();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                connStr = "Data Source = " + cbbTenServer.Text.Trim() + "; Trusted_Connection=True";
                conn = new SqlConnection(connStr);
                conn.Open();
                sql = "select * from sys.databases d where d.database_id>4";
                cmd = new SqlCommand(sql, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbbDatabase.Items.Add(dr[0].ToString());
                }
                cbbTenServer.Enabled = false;
                btnKetNoi.Enabled = false;
                cbbDatabase.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnNgatKetNoi_Click(object sender, EventArgs e)
        {
            cbbTenServer.Enabled = true;
            btnKetNoi.Enabled = true;
            cbbDatabase.Items.Clear();
            cbbDatabase.Items.Add("......");
            cbbDatabase.SelectedIndex = 0;
            cbbDatabase.Enabled = false;
            grbBackUp.Enabled = grbRestore.Enabled = false;
        }

        private void cbbDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbDatabase.SelectedIndex!=-1)
            {
                grbBackUp.Enabled = grbRestore.Enabled = true;
            }
            else
            {
                grbBackUp.Enabled = grbRestore.Enabled = false;
            }
            txtNoiBackUp.Clear();
            txtRestoreDBS.Clear();
        }

        private void txtNoiBackUp_TextChanged(object sender, EventArgs e)
        {
            if(txtNoiBackUp.Text.Trim()!=string.Empty)
            {
                btnBackUpDBS.Enabled = true;
            }    
            else
            {
                btnBackUpDBS.Enabled = false;
            }    
        }

        private void txtRestoreDBS_TextChanged(object sender, EventArgs e)
        {
            if (txtRestoreDBS.Text.Trim() != string.Empty)
            {
                btnRestoreDataBase.Enabled = true;
            }
            else
            {
                btnRestoreDataBase.Enabled = false;
            }
        }

        private void btnMoThuMucBackUp_Click(object sender, EventArgs e)
        {
            if(fbrBackUp.ShowDialog()==DialogResult.OK)
            {
                txtNoiBackUp.Text = fbrBackUp.SelectedPath;
            }    
        }

        private void btnBackUpDBS_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                sql="Backup database "+cbbDatabase.Text.ToString().Trim()+" To disk ='"+txtNoiBackUp.Text.Trim()+"\\" +cbbDatabase.Text+"-"+DateTime.Now.ToString("dddd,dd MM yyyy HH-mm-ss")+".bak' ";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sao lưu dữ liệu thành công ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnChonThuMucRestore_Click(object sender, EventArgs e)
        {
            if (txtNoiBackUp.Text == @"C:\Users\tuana\OneDrive\Documents\QLCHTAN_BACKUP")
                openFileDialog1.InitialDirectory = txtNoiBackUp.Text;

           openFileDialog1.Filter = "Backup Files (*.bak)|*.bak|All files(*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtRestoreDBS.Text = openFileDialog1.FileName;
            }    

        }

        private void btnRestoreDataBase_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection();
                conn.Open();
                sql = "alter database "+cbbDatabase.Text.ToString().Trim()+" set single_user with rollback immediate;";
                sql += "Restore database " + cbbDatabase.Text.ToString().Trim() + " from disk ='" + txtRestoreDBS.Text.Trim() + "' with replace;";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Phục hồi dữ liệu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
