<%@ Page Title="" Language="C#" MasterPageFile="~/User/User.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FastFood.User.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <script>

        window, onload = function () {
            var seconds = 5;
            this.setTimeout(function () {
                document.getElementById("<%=lblMsg.ClientID%>").style.display = "none";
            }, seconds * 1000);
        };
    </script>   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section class="book_section layout_padding">
        <div class="container">
            <div class="heading_container">
                <div class="align-self-end">
                    <asp:Label ID="lblMsg" runat="server" Visible="false"></asp:Label>
                </div>
                <asp:Label ID="lblHeaderMsg" runat="server" Text="<h2>Đăng kí tài khoản<h2>"></asp:Label>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="form-container">

                        <div>
                            <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Bắt buộc nhập tên của bạn" ControlToValidate="txtName"
                                ForeColor="Red" Display="Dynamic" SetFocusError="true"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revName" runat="server" ErrorMessage="Tên chỉ được ký tự"
                                ForeColor="Red" Display="Dynamic" SetFocusError="true" ValidationExpression="^[a-zA-Z\s]+$"
                                ControlToValidate="txtName"></asp:RegularExpressionValidator>
                            <asp:TextBox ID="txtName" runat="server" CssClass="form-control" placeholder="Nhập tên của bạn"
                                ToolTip="Full Name"></asp:TextBox>
                        </div>

                        <div>
                            <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="Tên đăng nhập là bắt buộc"
                                ControlToValidate="txtUsername" ForeColor="Red" Display="Dynamic" SetFocusError="true"></asp:RequiredFieldValidator>
                             <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Nhập tên đăng nhập"
                                ToolTip="Username"></asp:TextBox>
                        </div>

                        <div>
                            <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Bắt buộc nhập mật khẩu"
                                ControlToValidate="txtPassword" ForeColor="Red" Display="Dynamic" SetFocusError="true"></asp:RequiredFieldValidator>
                                 <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Nhập tên mật khẩu"
                                ToolTip="Password"></asp:TextBox>
                        </div>

                        <div>
                            <asp:RequiredFieldValidator ID="rfvMobile" runat="server" ErrorMessage="Bắt buộc nhập số điện thoại"
                                ControlToValidate="txtMobile"
                                ForeColor="Red" Display="Dynamic" SetFocusError="true"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revMobile" runat="server" ErrorMessage="Số điện thoại gồm nhiều hơn 10 số"
                                ForeColor="Red" Display="Dynamic" SetFocusError="true" ValidationExpression="^[0-9]{10}$"
                                ControlToValidate="txtMobile"></asp:RegularExpressionValidator>
                            <asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" placeholder="Nhập số điện thoại"
                                ToolTip="Mobile Number"></asp:TextBox>
                        </div>
                    </div>
                </div >

                <div class="row pl-4">
                    <div class="btn_box">
                        <asp:Button ID="btnRegsister" runat="server" Text="Đăng kí tài khoản" CssClass="btn btn-success rounded-pill pl-4 po-4 text-white" 
                             OnClick="btnRegsister_Click"/>

                        <asp:Label ID="lblAlreadyUser" runat="server" CssClass="pl-3 text-black-100"
                            Text="Bạn đã có tài khoản ? <a href='login.aspx' class='badge badge-info'>Đăng nhập ngay..</a>">
                        </asp:Label>
                    </div>
                </div>

            </div>
        </div>
    </section>

</asp:Content>
