<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="WebGUI.Sanpham" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Sản Phẩm</h2>
    <div>
        <div style="float:left; margin-right:20px">
            <asp:Label ID="Label1" runat="server" Text="Mã sản phẩm"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Tên sản phẩm"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
        <div style="float:left; margin-right:20px">
            <asp:Label ID="Label3" runat="server" Text="Giá sản phẩm"></asp:Label><br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Mã danh mục"></asp:Label><br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <div>
                <div>
                    <asp:Button ID="btnAdd" class="btn-success" style="padding:5px 30px; margin-left:15px; float:left" runat="server" Text="Thêm" OnClick="btnAdd_Click"/>
                </div>
                <div>
                    <asp:Button ID="btnEdit" class="btn-warning" style="padding:5px 30px; margin-left:15px; float:left" runat="server" Text="Sửa" OnClick="btnEdit_Click"/>
                </div>
                <div>
                  <asp:Button ID="btnDelete" class="btn-danger" style="padding:5px 30px; margin-left:15px" runat="server" Text="Xóa" OnClick="btnDelete_Click"/>
                </div>
          </div>
    <br />

    <div>
        <asp:GridView ID="Grsanpham" runat="server" OnSelectedIndexChanged="Grsanpham_SelectedIndexChanged" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </div>
</asp:Content>
