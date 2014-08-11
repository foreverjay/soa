﻿<%@ Page Language="C#" MasterPageFile="~/Demo.master" AutoEventWireup="true" CodeFile="ServiceReg.aspx.cs" Inherits="UDDI_ServiceReg" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"  Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.1, Version=9.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v9.1, Version=9.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="DevExpress.Web.v9.1, Version=9.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxTabControl" TagPrefix="dxtc" %>
<%@ Register Assembly="DevExpress.Web.v9.1, Version=9.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxClasses" tagprefix="dxw" %>
<%@ Register Assembly="DevExpress.Web.v9.1, Version=9.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dxlp" %>

<asp:Content ID="Content2" ContentPlaceHolderID="localCssPlaceholder" runat="server">
    <style type="text/css">
        td.buttonCell {
            padding-right: 6px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="phContent" Runat="Server">
    <asp:ScriptManager ID="ScriptManager" runat="server" />
    <dxlp:ASPxLoadingPanel ID="LoadingPanel" runat="server" ClientInstanceName="LoadingPanel" Modal="False" />
    <asp:UpdatePanel ID="UpdatePanel" runat="server">
    <ContentTemplate>
        <table cellpadding="0" cellspacing="0">
            <tr>
                <td class="buttonCell">
                    <dxe:ASPxComboBox ID="cbProvider" runat="server" ToolTip="请选择服务提供者" AutoPostBack="true" DataSourceID="OdsProvider" 
                        ValueField="业务编码" TextField="描述" OnSelectedIndexChanged="cbProvider_SelectedIndexChanged" />
                </td>           
                <td class="buttonCell">
                    <dxe:ASPxButton ID="btnAdd" runat="server" Text="新增服务" UseSubmitBehavior="False" AutoPostBack="false">
                        <ClientSideEvents Click="function(){ grid.AddNewRow(); }" />
                    </dxe:ASPxButton>
                </td>     
            </tr>
        </table>
        <br />
        <dxwgv:ASPxGridView ID="grid" ClientInstanceName="grid" runat="server" DataSourceID="OdsService" KeyFieldName="服务编码" AutoGenerateColumns="False" Width="100%">
            <%-- BeginRegion Columns --%>
            <Columns>
                <dxwgv:GridViewCommandColumn VisibleIndex="0" Caption="操作" HeaderStyle-HorizontalAlign="Center">
                    <EditButton Visible="True" Text="编辑" />
                    <DeleteButton Visible="true" Text="删除" />
                </dxwgv:GridViewCommandColumn>
                <dxwgv:GridViewDataComboBoxColumn FieldName="业务编码" Caption="服务提供者" VisibleIndex="1" >
                    <PropertiesComboBox TextField="业务名称" ValueField="业务编码" EnableSynchronization="False" EnableIncrementalFiltering="False" DataSourceID="OdsProvider" />
                    <EditFormSettings Visible="True" VisibleIndex="1" />
                </dxwgv:GridViewDataComboBoxColumn>
                <dxwgv:GridViewDataHyperLinkColumn FieldName="服务编码" Caption="服务名称" VisibleIndex="2" ReadOnly="true" >
                    <PropertiesHyperLinkEdit TextField="服务名称" TextFormatString="{0}" NavigateUrlFormatString="ServiceBinding.aspx?SID={0}" >
                    </PropertiesHyperLinkEdit>
                    <EditFormSettings Visible="False" />
                </dxwgv:GridViewDataHyperLinkColumn>
                <dxwgv:GridViewDataColumn FieldName="服务名称" VisibleIndex="3" Caption="服务名称" Visible="false">
                    <EditFormSettings Visible="true" VisibleIndex="3" ColumnSpan="2" />
                </dxwgv:GridViewDataColumn>                
                <dxwgv:GridViewDataMemoColumn FieldName="描述" VisibleIndex="3" Caption="服务描述" >
                    <EditFormSettings Visible="true" VisibleIndex="4" ColumnSpan="2" />
                    <PropertiesMemoEdit Height="80px" />
                </dxwgv:GridViewDataMemoColumn>
                <dxwgv:GridViewDataComboBoxColumn FieldName="个人编码" VisibleIndex="4" Caption="服务管理员">
                    <PropertiesComboBox TextField="姓名" ValueField="个人编码" EnableSynchronization="False" EnableIncrementalFiltering="False" DataSourceID="OdsUser">
                    </PropertiesComboBox>
                    <EditFormSettings Visible="true" VisibleIndex="2" />
                </dxwgv:GridViewDataComboBoxColumn>    
            </Columns>
            <%-- EndRegion --%>
            <SettingsEditing Mode="EditFormAndDisplayRow"/>
            <SettingsPager AlwaysShowPager="true" />
            <SettingsBehavior ConfirmDelete="true" />
            <SettingsText EmptyDataRow="暂无数据！" CommandCancel="取消" CommandUpdate="保存" ConfirmDelete="您确定要删除这条记录吗？" />
        </dxwgv:ASPxGridView>   
        <script type="text/javascript">
            //调用条件：页面包含ASPxLoadingPanel ClientInstanceName="LoadingPanel"
            InitCustomLoadingPanel(); 
        </script>
    </ContentTemplate>
    </asp:UpdatePanel>
    <%-- BeginRegion DataSource --%>
    <asp:ObjectDataSource ID="OdsUser" runat="server" 
        TypeName="JN.Esb.Portal.ServiceMgt.服务目录服务.注册服务目录服务" 
        DataObjectTypeName="JN.Esb.Portal.ServiceMgt.服务目录服务.个人" 
        SelectMethod="获得所有服务管理员" 
        />
    <asp:ObjectDataSource ID="OdsProvider" runat="server" 
        TypeName="JN.Esb.Portal.ServiceMgt.服务目录服务.注册服务目录服务" 
        DataObjectTypeName="JN.Esb.Portal.ServiceMgt.服务目录服务.业务实体" 
        SelectMethod="获得所有服务提供者"
        />
    <asp:ObjectDataSource ID="OdsService" runat="server" 
        TypeName="JN.Esb.Portal.ServiceMgt.服务目录服务.注册服务目录服务"
        SelectMethod="获得具体服务_服务提供者"  UpdateMethod="修改具体服务" InsertMethod="新增服务" DeleteMethod="删除具体服务"
        OnSelecting="OdsService_Selecting" OnInserting="OdsService_Inserting" OnUpdating="OdsService_Updating" OnDeleting="OdsService_Deleting">
    </asp:ObjectDataSource>
</asp:Content>
