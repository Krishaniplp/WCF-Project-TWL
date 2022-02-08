using Ref;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDepartmentService" in both code and config file together.
    [ServiceContract]
    public interface IDepartmentService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
         UriTemplate = "GetDepartment",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string LoadDepartmentDetails();

        [OperationContract]
        [WebInvoke(Method = "POST",
         UriTemplate = "UsingIdDepartment",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string LoadDepartmentUSINGID(Department_Ref oDepartment_Ref);

        [OperationContract]
        [WebInvoke(Method = "POST",
         UriTemplate = "InsertDepartment",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string InsertDepartment(Department_Ref oDepartment_Ref);

        [OperationContract]
        [WebInvoke(Method = "POST",
         UriTemplate = "DeleteDepartment",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string DeleteDepartment(Department_Ref oDepartment_Ref);

        [OperationContract]
        [WebInvoke(Method = "GET",
         UriTemplate = "GetEmployee",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string LoadEmployeeDetails();

        [OperationContract]
        [WebInvoke(Method = "POST",
         UriTemplate = "UsingIdEmployee",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string LoadEmployeeUSINGID(Employee_Ref oEmployee_Ref);

        [OperationContract]
        [WebInvoke(Method = "POST",
         UriTemplate = "InsertEmployee",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string InsertEmployee(Employee_Ref oEmployee_Ref);

        [OperationContract]
        [WebInvoke(Method = "POST",
         UriTemplate = "DeleteEmployee",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string DeleteEmployee(Employee_Ref oEmployee_Ref);

        [OperationContract]
        [WebInvoke(Method = "POST",
        UriTemplate = "UpdateDepartment",
        BodyStyle = WebMessageBodyStyle.Wrapped,
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json)]
        string UpdateDepartment(Department_Ref oDepartment_Ref);

        //[OperationContract]
        //[WebInvoke(Method = "POST",
        //UriTemplate = "UpdateEmployee",
        //BodyStyle = WebMessageBodyStyle.Wrapped,
        //RequestFormat = WebMessageFormat.Json,
        //ResponseFormat = WebMessageFormat.Json)]
        //string UpdateEmployee(Employee_Ref oEmployee_Ref);

        [OperationContract]
        [WebInvoke(Method = "GET",
         UriTemplate = "GetStatus",
         BodyStyle = WebMessageBodyStyle.Wrapped,
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        string LoadAllStatus();
    }
}

