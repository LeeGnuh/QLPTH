<%@ Page Title="Người dùng" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NguoiDung.aspx.cs" Inherits="WebGUI.Nguoidung" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Quản Lý Người Dùng</h2>
    <div>
        <div style="float:left; margin-right:20px">
            <asp:Label ID="Label1" runat="server" Text="Mã người dùng"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Tên người dùng"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div style="float:left; margin-right:20px">
            <asp:Label ID="Label3" runat="server" Text="Tên đăng nhập"></asp:Label><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Mật khẩu"></asp:Label><br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <div>
                <div>
                    <asp:Button ID="btnAdd" class="btn-success" style="padding:5px 30px; margin-left:15px; float:left" runat="server" Text="Thêm"/>
                </div>
                <div>
                    <asp:Button ID="btnEdit" class="btn-warning" style="padding:5px 30px; margin-left:15px; float:left" runat="server" Text="Sửa"/>
                </div>
                <div>
                  <asp:Button ID="btnDelete" class="btn-danger" style="padding:5px 30px; margin-left:15px" runat="server" Text="Xóa"/>
                </div>
          </div>
    <br />

    <div>
        <asp:GridView ID="Grnguoidung" runat="server">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    
</asp:Content>
