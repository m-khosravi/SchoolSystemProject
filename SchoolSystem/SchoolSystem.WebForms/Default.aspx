﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SchoolSystem.WebForms._Default" %>

<%@ Register Src="~/CustomControls/Home/StudentScheduleControl.ascx" TagPrefix="custom" TagName="StudentScheduleControl" %>
<%@ Register Src="~/CustomControls/Home/NewsfeedControl.ascx" TagPrefix="custom" TagName="NewsfeedControl" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="frame program col-xs-4">
            <custom:StudentScheduleControl runat="server" ID="StudentScheduleControl" />
        </div>
        <asp:UpdatePanel ID="updatePanelImportant" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <custom:NewsfeedControl runat="server" ID="NewsfeedControl" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

