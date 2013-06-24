<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Src="~/Widget/Footer/UC_Footer.ascx" TagName="UC_Footer" TagPrefix="cms" %>
<%@ Register Src="~/Widget/Header/UC_Header.ascx" TagName="UC_Header" TagPrefix="cms" %>
<html>
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <div id="pagecontainer" style="width: 960px; margin: 0 auto;">
        <asp:PlaceHolder ID="bodyplaceholder" runat="server">
            <cms:UC_Header ID="UC_Header" runat="server" cssclass="PagedArticleList_Default" />
            <cms:UC_Footer ID="UC_Footer" runat="server" cssclass="PagedArticleList_Default" />
        </asp:PlaceHolder>
    </div>
</body>
</html>
