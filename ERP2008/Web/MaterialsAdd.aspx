﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="MaterialsAdd.aspx.cs" Inherits="ERP.Web.MaterialsAdd" Title="ERP-添加新物料" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderOperationMenu" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderRealContent" runat="server">
    <div style="height:649px">
     <!--img src="images/添加新物料.jpg" /-->
<br />
<br />
<br />
<br />
<br />
<table cellpadding="0" cellspacing="0" class="style1">
        <tr>
            <td >
                <table align="center" cellpadding="0" cellspacing="0" class="style1">
                    <tr>
                        <td align="right" class="style2" height="32">
                            入库仓库：</td>
                        <td align="left" class="style3">
                            <asp:DropDownList ID="DropDownList" runat="server"
                            DataSourceID="SqlDataSource1" DataTextField="WName" DataValueField="WName">
                            </asp:DropDownList>

                            <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                            ConnectionString="<%$ ConnectionStrings:ERPDB %>" 
                            SelectCommand="SELECT [WName] FROM [Warehouses]" 
                            ProviderName="<%$ ConnectionStrings:ERPDB.ProviderName %>">
                            </asp:SqlDataSource>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style2" height="32">
                            物料代码：</td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxMCode" runat="server"></asp:TextBox>
                            <span style="color: #FF0000">*</span><asp:RequiredFieldValidator 
                                ID="RequiredFieldValidatorTextBoxMCode" runat="server" ErrorMessage="不能为空!" 
                                ControlToValidate="TextBoxMCode" Font-Size="Small"></asp:RequiredFieldValidator>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            物料名称：</td>
                        <td align="left" class="style5">
                            <asp:TextBox ID="TextBoxMName" runat="server"></asp:TextBox>
                            <span style="color: #FF0000">*</span><asp:RequiredFieldValidator 
                                ID="RequiredFieldValidatorTextBoxMName" runat="server" ErrorMessage="不能为空!" 
                                ControlToValidate="TextBoxMName" Font-Size="Small"></asp:RequiredFieldValidator>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            型号规格：</td>
                        <td align="left" class="style3" height="32">
                            <asp:TextBox ID="TextBoxMModel" runat="server"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style2">
                            材质：</td>
                        <td class="style3" height="32">
                            <asp:TextBox ID="TextBoxMMaterial" runat="server"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            国标：</td>
                        <td class="style5">
                            <asp:TextBox ID="TextBoxMStandard" runat="server"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style4">
                            单位：</td>
                        <td class="style5">
                            <asp:TextBox ID="TextBoxMUnit" runat="server"></asp:TextBox>
                        </td>
                        
                    </tr>
                    <tr>
                        <td align="right" class="style2" height="32">
                            数量：</td>
                        <td align="left" class="style3">
                            <asp:TextBox ID="TextBoxMNumber" runat="server"></asp:TextBox>
                            <span style="color: #FF0000">
                            *</span>
                        </td>
                        
                    </tr> 

                    </table>
                    
            </td>
        </tr>
        <tr><td height="32" >
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
       
            <asp:Button ID="ButtonSubmit" runat="server" Text="提交"  
                style="height: 26px; width: 40px;" onclick="ButtonSubmit_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <input type="reset" name="buttonCancel" id="button" value="重置" />
            
            </td></tr>
    </table>
 <br />
<br />
</div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderBottomNav" runat="server">
</asp:Content>
