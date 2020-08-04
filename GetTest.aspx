<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetTest.aspx.cs" Inherits="WebApplication2.GetTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="GetTest-1.aspx" method ="get"> 
        <div>
            <select name ="userID">
                <option>aaaa</option>
                 <option>bbbb</option>
                   <option>cccc</option>                
 
                </select> 

<input type ="submit" value="조회" />
        </div>
    </form>
</body>
</html>
