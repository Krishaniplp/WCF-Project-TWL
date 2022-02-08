<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_Client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.11.4/css/jquery.dataTables.css">

    <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.11.4/js/jquery.dataTables.js"></script>


    <script type="text/javascript">

        var dtt = [];
        var Dept_ID = [];

        window.onload = function () {
            loadPRAll();
            formload();
        };

        function loadPRAll() {

            $.ajax({
                type: "GET",
                url: "http://localhost:61814/DepartmentService.svc/GetDepartment",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {

                    dtt = JSON.parse(data.LoadDepartmentDetailsResult);
                    /*debugger;*/
                    $('#tblexample').dataTable({
                        data: dtt,
                        destroy: true,
                        "columns": [

                            { "data": "Dept_Id" },
                            { "data": "Dept_Name" },
                            { "data": "Dept_Status" },
                            {
                                "data": "Dept_Id",
                                "render": function (data) {
                                    return `<button type="button" id ="editbtn" class="buttonbutton1"  onclick=editDepartment(${data})><icon-icon name="edit" ></icon-icon>EDIT</button>`;
                                }
                            },
                        ]
                    });
                },
                error: function (xhr, status, error) {
                    // alert('errr');
                    // toastr.warning('Server Error', "Warning");
                }
            })
        }

        //function statusResult(status) {
        //    var s = '<Option>please select the department ID</Option>'
        //    for (var i = 0; i < deptStatus.length; i++) {
        //        alert('done');
        //        s += '<option>' + deptStatus[i].Status + '</option>';

        //    } $("#dept_St").html(s)
        //}


        function formload() {
            $.ajax({
                type: "GET",
                url: "http://localhost:61814/DepartmentService.svc/GetStatus",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {


                    var Dept_Status = JSON.parse(data.LoadAllStatusResult);
                    /*console.log(Dept_Status);*/
                    var s = '<Option>please select the department ID</Option>'
                    for (var i = 0; i < Dept_Status.length; i++) {
                        /*alert('done');*/
                        //    s += '<option>' + Dept_Status[i].Dept_Status + '</option>';
                        //} $("#Dept_Status").html(s)
                        $('#Dept_Status').append($("<option></option>").val(Dept_Status[i].Status).html(Dept_Status[i].Status));                       
                    }
                    },
                    error: function (xhr, status, error) {
                        alert('error frmLOad');
                        toastr.warning('Server Error', "Warning");
                    }
                })
        }
        function editDepartment(dep) {

            $.ajax({
                type: "POST",
                url: "http://localhost:61814/DepartmentService.svc/UsingIdDepartment",
                data: JSON.stringify({
                    "oDepartment_Ref":
                    {
                        Dept_Id: dep

                    }
                }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {
                    /* $('#dept_St').*/
                    //$("#dept_St").html(deptStatus)
                    Dept_Id = JSON.parse(data.LoadDepartmentUSINGIDResult);

                    var dID = Dept_Id[0].Dept_Id;
                    var dName = Dept_Id[0].Dept_Name;
                    var dStatus = Dept_Id[0].Dept_Status;

                    $('#Dept_Id').val(dID);
                    $('#Dept_Name').val(dName);
                  /*  $('#Dept_Status').append($("<option></option>").val(dStatus).html(dStatus));*/
                    $('#Dept_Status').prop('selected=', dStatus);
                },
                error: function (xhr, status, error) {
                    // alert('errreedd');
                    /*toastr.warning('Server Error', "Warning");*/
                }
            });
        }
        function InsertDepartment() {

            var Dept_Id = $('#Dept_Id').val();
            var Dept_Name = $('#Dept_Name').val();
            var Dept_Status = $('#Dept_Status').val();

            $.ajax({
                type: "POST",
                url: "http://localhost:61814/DepartmentService.svc/InsertDepartment",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: JSON.stringify({
                    "oDepartment_Ref":
                    {
                        "Dept_Id": Dept_Id,
                        "Dept_Name": Dept_Name,
                        "Dept_Status": Dept_Status
                    }
                }),
                success: function (data) {

                    var dtt = JSON.parse(data.InsertDepartmentResult);

                },
                error: function (xhr, status, error) {
                    alert('errr');
                    toastr.warning('Server Error', "Warning");
                }
            })
        }

   </script>

    <div class="jumbotron">
        <h1>ASP.NET</h1>
    </div>
    <div class="row">
        <div class="col-md-12">
            <h2>Getting started</h2>
            <table id="tblexample">
                <thead>
                    <tr>
                        <th>Dept_Id</th>
                        <th>Dept_Name</th>
                        <th>Dept_Status</th>
                        <th>Edit</th>
                    </tr>
                </thead>
            </table>
        </div>
        <div class="row">
            <h2>Insert Department</h2>
            <label for="ID">ID:</label><br>
            <input type="text" id="Dept_Id" name="ID"><br>
            <label for="name">NAME:</label><br>
            <input type="text" id="Dept_Name" name="NAME"><br>
            <label for="status">STATUS:</label><br>
            <select id="Dept_Status" class="form-control select2"><option selected=""></option></select>
            <input type="submit" onclick="InsertDepartment()" value="Submit">
        </div>

    </div>

</asp:Content>
