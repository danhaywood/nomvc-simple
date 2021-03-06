﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.WithServices.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="NakedObjects.Resources" %>
<%@ Import Namespace="NakedObjects.Web.Mvc.Html" %>

<%-- This view is used, by default, for an object that implements IViewModelEdit,
    or that implements IViewModelSwitchable when it is in edit mode.  Otherwise
    viewmodels are rendered like any other objects using the ObjectView view. The use of
    this view for editable viewmodels is to avoid the rendering of a Save button.--%>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Html.ObjectTitle(Model) + "Edit View Model" %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <%: Html.TabbedHistory(Model) %>   
    <div class="<%: Html.ViewModelClass(Model) %>" id="<%: Html.ObjectTypeAsCssId(Model) %>">
            <%: Html.ObjectTitle(Model) %>
            <%: Html.ValidationSummary(true, MvcUi.EditError) %>
            <%: Html.UserMessages() %>
            <%
                using (Html.BeginForm(IdHelper.EditAction,
                                      Html.TypeName(Model).ToString(),
                                      new {id = Html.GetObjectId(Model).ToString()},
                                      FormMethod.Post,
                                      new {@class = IdHelper.EditName})) { %>
                <%:Html.PropertyListEdit(Model) %> 
                <%:Html.MenuOnTransient(Model)%>    
            <% } %>
    </div>
</asp:Content>