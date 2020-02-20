<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebTrainee.aspx.cs" Inherits="TraineeAppp.WebTrainee" %>

<asp:Content ID="id1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

    <asp:Label ID="Label1" runat="server" Text="Trainee ID:"></asp:Label>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Must Enter ID" ControlToValidate="TextBox1" ForeColor="Red" ValidationGroup="vg"></asp:RequiredFieldValidator>

    <br/>
    
    <asp:TextBox ID="TextBox1" runat="server" MaxLength="6" ValidationGroup="vg"></asp:TextBox>
    <br/>

    <asp:Label ID="Label2" runat="server" Text="Trainee Name:"></asp:Label>
    <br/>
   
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br/>



    <asp:Label ID="Label3" runat="server" Text="Training Location:"></asp:Label>
    <br/>
  
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br/>



    <asp:Label ID="Label4" runat="server" Text="Training Domain:"></asp:Label>
    <br/>
   
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <br/>


    <asp:Label ID="Label5" runat="server" Text="StartDate:"></asp:Label>
    <br/>
   
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    <br/>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Date Must Be Between 1-Nov-2018 to 31-Jan-2020" ControlToValidate="TextBox5" ForeColor="Red" MaximumValue="31-Jan-2020" MinimumValue="1-Nov-2018"></asp:RangeValidator>


        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />


</div>


<div class="jumbotron">
<asp:Label ID="Label6" runat="server" Text="Enter ID to search Data:"></asp:Label>
<br/>
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    <br />
    <br />

    <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
    
    <br />
    <br/>
    <asp:GridView ID="GridView2" runat="server"></asp:GridView>

</div>


<div class="jumbotron">
    <asp:Label ID="Label7" runat="server" Text="Enter Id to Update Data:"></asp:Label>
    <br>
    <asp:TextBox ID="utid" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label8" runat="server" Text="New Tech Domain:"></asp:Label>
    <br>
    <asp:TextBox ID="newTech" runat="server"></asp:TextBox>
    <br />
    <br />
    

    <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />


    <br />
    <asp:GridView ID="GridView3" runat="server">
    </asp:GridView>
    <br />


</div>
</asp:Content>