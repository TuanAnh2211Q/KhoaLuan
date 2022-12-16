using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace FastFood.User
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegsister_Click(object sender, EventArgs e)
        {
            string actionName = string.Empty, imagePath = string.Empty, fileExtension = string.Empty;
            bool isValidToExecute = false;
            int UserId = Convert.ToInt32(Request.QueryString["id"]);
            con = new SqlConnection(Connection.GetConnectionString());
            cmd = new SqlCommand("User_Crud", con);
            cmd.Parameters.AddWithValue("@Action", UserId == 0 ? "INSERT" : "UPDATE");
            cmd.Parameters.AddWithValue("@ProductId", UserId);
            cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text.Trim());
            cmd.Parameters.AddWithValue("@Oassword", txtPassword.Text.Trim());
           
            if (isValidToExecute)
            {
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    actionName = UserId == 0 ?
                    "Đăng kí tài khoản thành công! <b><a herf='Login.aspx'>Bấm vào đây</a></b> để đăng nhập" :
                    "Cập nhật chi tiết thành công! <b><a herf='Profile.aspx'>Kiểm tra ở đây</a></b>";
                    lblMsg.Visible = true;
                    lblMsg.Text = "<b> " + txtUsername.Text.Trim() + "</b>" + actionName;
                    lblMsg.CssClass = "alert alert-success";                   
                }
                catch(SqlException ex)
                {
                    if(ex.Message.Contains("Vi phạm ràng buộc UNIQUE KEY"))
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "<b>" + txtUsername.Text.Trim() + "</b> tên đăng nhập đã tồn tại, thử lại một tên khác...!";
                        lblMsg.CssClass = "alert alert-danger";
                    }
                }
                catch (Exception ex)
                {
                    lblMsg.Visible = true; ;
                    lblMsg.Text = "Eror - " + ex.Message;
                    lblMsg.CssClass = "alert alert-danger";
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void clear()
        {
            txtName.Text= string.Empty;
            txtUsername.Text= string.Empty;
            txtPassword.Text= string.Empty;
            txtMobile.Text= string.Empty;
        }
    }
}