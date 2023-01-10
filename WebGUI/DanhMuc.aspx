<%@ Page Title="Danh Mục" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhMuc.aspx.cs" Inherits="WebGUI.Danhmuc" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


        <h2>Danh Mục</h2>
    <div>
        <div style="float:left; margin-right:20px">
            <asp:Label ID="Label1" runat="server" Text="Mã danh mục"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Tên danh mục"></asp:Label><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div>
    </div>
    <br />
    <div>
                <div>
                    <asp:Button ID="btnAdd" class="btn-success" style="padding:5px 30px; margin-left:15px; float:left" runat="server" Text="Thêm" OnClick="btnAdd_Click1"/>
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
        <asp:GridView ID="Grdanhmuc" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="Gray" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </div>

</asp:Content>
