<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonInfo.aspx.cs" Inherits="WebApplication1.PersonInfo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>
<title></title>
    
    
</head>
<body>
    <form id="form1" runat="server">
      
        <div >
                <div class="row">   
                   
                        <h3 style="text-align:center">User Registration Details</3>
                    </div>
                    
             </div>
        <br />
    

        <div style="display:block"> 
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-2">
                    <asp:Label ID="Label1" runat="server" class="text-lg-start" Text="Label">First Name:<span style="color:red" CssClass="form-control-color">*</span> </asp:Label>
                    </div>
                    <div class="col-sm-2">
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator" runat="server" ErrorMessage=" First Name cannot be blank" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>  
                </div>
                 <div class="col-sm-2">
                     <asp:Label ID="Label8" runat="server" Text="Label" CssClass="align-content-end">Last Name<span style="color:red" CssClass="form-control-color">*</span> </asp:Label>
                      </div>
                    <div class="col-sm-2">
            <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox> 
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage=" Last Name cannot be blank" ControlToValidate="TextBox6" ForeColor="Red"></asp:RequiredFieldValidator>  </div>
                <div class="col-sm-2"></div>
                </div>
                 
           
       
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-2">
                 <asp:Label ID="Label3" runat="server" Text="Label" CssClass="align-content-end">Email:<span style="color:red" CssClass="form-control-color">*</span>  </asp:Label>
                      </div>
                <div class="col-sm-2">
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email cannot be blank" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator>  
           <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter proper email format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>  
            </div> 
                <div class="col-sm-2">
<asp:Label ID="Label4" runat="server" Text="Label" CssClass="align-content-end">Password:<span style="color:red" CssClass="form-control-color">*</span> </asp:Label>
                    </div>
                    <div class="col-sm-2">
<asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Password cannot be blank" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="col-sm-2"></div>
                </div>
           

       
                  
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-2">
                         <asp:Label ID="Label5" runat="server" Text="Label" CssClass="align-content-end">Mobile:<span style="color:red" CssClass="form-control-color">*</span> </asp:Label>
                            </div>
                           <div class="col-sm-2">
            <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>                    
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mobile cannot be blank" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator>  
           <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="Mobile number must be 10 digit" ForeColor="Red" ValidationExpression="\d{10}"></asp:RegularExpressionValidator> 
 
                </div>
              <div class="col-sm-2">
                     
              </div>
             <div class="col-sm-2"></div>
            </div>
  



                  
            <div class="row">
            <div class="col-sm-2"></div>
                <div class="col-sm-4">
                       <asp:Label ID="Label6" runat="server" Text="Label" >Gender:<span style="color:red" CssClass="form-control-color">*</span> </asp:Label>
     <asp:SqlDataSource  ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:UserRegistrationConnectionString2 %>" SelectCommand="SELECT * FROM [Gender]"></asp:SqlDataSource>         
            <asp:RadioButtonList ID="RadioButtonList1" CssClass="form-control" runat="server" DataTextField="Gender" DataValueField="GenderId" DataSourceID="SqlDataSource2"  ></asp:RadioButtonList>
                </div>
                <div class="col-sm-4">
                     <asp:Label ID="Label7" runat="server" Text="Label">Hobbies:<span style="color:red" CssClass="form-control-color">*</span> </asp:Label>
    <asp:CheckBoxList CssClass="form-control" ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Hobbies" DataValueField="HobbiesId">
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="SqlDataSource1"  runat="server" ConnectionString="<%$ ConnectionStrings:UserRegistrationConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [Hobbies]"></asp:SqlDataSource>
                </div>
                <div class="col-sm-2"></div>
                </div>
        <br />
               
         
            



       

          
          <%--<asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender" />  
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female"   GroupName="gender" />  
    
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Others" GroupName="gender" />--%>

           
           <%--   <asp:Label Text="text" runat="server" />
          <asp:Repeater ID="rptCountries" runat="server">
    <ItemTemplate>
        <label>
            <asp:RadioButton ID="rbCountry" runat="server" GroupName="Gender" 
                Text='<%# Eval("Gender1") %>' Value='<%# Eval("GenderId") %>' />
        </label>
    </ItemTemplate>
</asp:Repeater> --%> 
       
        <div style="text-align:center">
            <p style="color:red"> * Marked Feilds are Mandatory </p>
        </div>

          
            <div class="row">
            <div class="col-sm-2">
                <br />
                </div>
                <div class="col-sm-4">
           <asp:Button ID="Button1" runat="server" CssClass="btn btn-success" OnClick="Button1_Click" Text="Save" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server"   OnClick="Button2_Click" Text="Cancel" CssClass=" btn btn-danger" />
                    <br />
                    <br />
            </div>
                <div class="col-sm-4">
                    <br />
                </div>
           <div class="col-sm-2"></div>
          </div>
         </div>
            
        
         
        <div class="d-flex justify-content-center">
                                 
            <asp:GridView ID="gridviewInfo" class="form-control" runat="server"  AllowCustomPaging="False" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5"  OnPageIndexChanging="gridviewInfo_PageIndexChanging">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerSettings PageButtonCount="25" FirstPageText="" LastPageText="" NextPageText="" Position="Top" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
 <%-- <dx:ASPxGridView ID="Grid" runat="server" AutoGenerateColumns="False" Width="100%" DataSourceID="OrdersDataSource" KeyFieldName="OrderID">
    <Columns>
    ...
    </Columns>
    <Settings VerticalScrollableHeight="300" />
    <SettingsPager PageSize="20">
        <PageSizeItemSettings Visible="true" ShowAllItem="true" />
    </SettingsPager>
</dx:ASPxGridView>--%>
            
        </div>


    </form> 
</body>
</html>
