using BAL;
using Newtonsoft.Json;
using Ref;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DepartmentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DepartmentService.svc or DepartmentService.svc.cs at the Solution Explorer and start debugging.
    public class DepartmentService : IDepartmentService
    {
        public string LoadDepartmentDetails()
        {
            try
            {

                Department_BAL oDepartment_BAL = new Department_BAL();

                DataTable dt;
                dt = oDepartment_BAL.LoadAllDepartment(null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string LoadDepartmentUSINGID(Department_Ref oDepartment_Ref)
        {
            try
            {

                Department_BAL oDepartment_BAL = new Department_BAL();

                DataTable dt;
                dt = oDepartment_BAL.LoadUSINGIDDepartment(oDepartment_Ref, null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string InsertEmployee(Employee_Ref oEmployee_Ref)
        {
            try
            {

                Employee_BAL oEmployee_BAL = new Employee_BAL();

                DataTable dt;
                dt = oEmployee_BAL.InsertEmployee(oEmployee_Ref, null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string InsertDepartment(Department_Ref oDepartment_Ref)
        {
            try
            {

                Department_BAL oDepartment_BAL = new Department_BAL();

                DataTable dt;
                dt = oDepartment_BAL.InsertDepartment(oDepartment_Ref, null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string DeleteDepartment(Department_Ref oDepartment_Ref)
        {
            try
            {

                Department_BAL oDepartment_BAL = new Department_BAL();

                DataTable dt;
                dt = oDepartment_BAL.DeleteDepartment(oDepartment_Ref, null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string LoadEmployeeDetails()
        {
            try
            {

                Employee_BAL oEmployee_BAL = new Employee_BAL();

                DataTable dt;
                dt = oEmployee_BAL.LoadEmployeeDetails(null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string LoadEmployeeUSINGID(Employee_Ref oEmployee_Ref)
        {
            try
            {

                Employee_BAL oEmployee_BAL = new Employee_BAL();

                DataTable dt;
                dt = oEmployee_BAL.LoadUSINGIDEmployee(oEmployee_Ref, null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string DeleteEmployee(Employee_Ref oEmployee_Ref)
        {
            try
            {

                Employee_BAL oEmployee_BAL = new Employee_BAL();

                DataTable dt;
                dt = oEmployee_BAL.DeleteEmployee(oEmployee_Ref, null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public string LoadAllStatus()
        {
            try
            {

                Status_BAL oStatus_BAL = new Status_BAL();

                DataTable dt;
                dt = oStatus_BAL.LoadAllStatus(null);

                return JsonConvert.SerializeObject(dt);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public string UpdateDepartment(Department_Ref oDepartment_Ref)
        {
            {
                try
                {
                    Department_BAL oDepartment_BAL = new Department_BAL();

                    DataTable dt;
                    dt = oDepartment_BAL.UpdateDepartment(oDepartment_Ref, null);

                    return JsonConvert.SerializeObject(dt);
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }
    }

}
