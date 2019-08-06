<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesList.aspx.cs" Inherits="ExportToWord.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />  
    <script src="scripts/jquery-3.3.1.min.js"></script>  
    <script src="scripts/bootstrap.min.js"></script>  
    <link href="Content/dataTables.bootstrap4.min.css" rel="stylesheet" />  
    <script src="scripts/dataTables.bootstrap4.min.js"></script>  
    <script src="scripts/jquery.dataTables.min.js"></script>  
    <script type="text/javascript">  
        $(document).ready(function () {  
            $("#EmployeeGridViewList").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();  
        });  
    </script>  
    <style>  
        .btnMargin {  
            margin-bottom: 10px !important;
        }  
    </style>
</head>
<body>  
    <form id="form1" runat="server">  
        <div class="container py-4">  
            <h5 class="text-uppercase text-center">How to export gridview data in word,excel and Pdf format using asp.net</h5>  
            <div class="card">  
                <div class="card-header bg-primary text-white">  
                    <h5 class="card-title text-uppercase">Employees List</h5>  
                </div>  
                <div class="card-body">  
                    <asp:Button ID="btnExportToWord" CssClass="btnMargin btn btn-outline-primary rounded-0" runat="server" Text="ExportToWord" OnClick="btnExportToWord_Click" />  
                    <asp:Button ID="btnExportToExcel" CssClass="btnMargin btn btn-outline-primary rounded-0" runat="server" Text="ExportToExcel" OnClick="btnExportToExcel_Click" />  
                    <asp:Button ID="btnExportToPDF" CssClass="btnMargin btn btn-outline-primary rounded-0" runat="server" Text="ExportToPDF" OnClick="btnExportToPDF_Click" />  
                    <asp:GridView ID="EmployeeGridViewList" CssClass="table table-bordered" runat="server"></asp:GridView>  
                </div>  
            </div>  
        </div>  
    </form>  
</body>  
</html>
