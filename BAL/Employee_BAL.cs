using DAL;
using Ref;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class Employee_BAL
    {
        public DataTable LoadEmployeeDetails(DB_Handler oDB_Handle)
        {
            DAL_Employee oEmployee_DL = new DAL_Employee();
        DataTable oDataTable = new DataTable();
            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handler();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                    oDataTable = oEmployee_DL.LoadEmployeeDetails(oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
{
           oDB_Handle.RollbackTransaction();
           oDB_Handle.CloseConnection();
           throw ex;
}
        return oDataTable;
        }
        //oDB_Handle should pass every 
        public DataTable InsertEmployee(Employee_Ref oEmployee_Ref, DB_Handler oDB_Handle)
        {
            DAL_Employee oEmployee_DL = new DAL_Employee();
            DataTable oDataTable = new DataTable();
            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handler();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oEmployee_DL.InsertEmployee(oEmployee_Ref, oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                oDB_Handle.RollbackTransaction();
                oDB_Handle.CloseConnection();
                throw ex;
            }
            return oDataTable;
        }

        public DataTable DeleteEmployee(Employee_Ref oEmployee_Ref, DB_Handler oDB_Handle)
        {
            DAL_Employee oEmployee_DL = new DAL_Employee();
            DataTable oDataTable = new DataTable();
            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handler();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oEmployee_DL.DeleteEmployee(oEmployee_Ref, oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                oDB_Handle.RollbackTransaction();
                oDB_Handle.CloseConnection();
                throw ex;
            }
            return oDataTable;
        }
        public DataTable LoadUSINGIDEmployee(Employee_Ref oEmployee_Ref, DB_Handler oDB_Handle)
        {
            DAL_Employee oEmployee_DL = new DAL_Employee();
            DataTable oDataTable = new DataTable();
            try
            {
                bool newDBHandle = false;
                if (oDB_Handle == null)
                {
                    oDB_Handle = new DB_Handler();
                    oDB_Handle.OpenConnection();
                    oDB_Handle.BeginTransaction();
                    newDBHandle = true;
                }
                oDataTable = oEmployee_DL.LoadUSINGIDEmployee(oEmployee_Ref, oDB_Handle);
                if (newDBHandle)
                {
                    oDB_Handle.CommitTransaction();
                    oDB_Handle.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                oDB_Handle.RollbackTransaction();
                oDB_Handle.CloseConnection();
                throw ex;
            }
            return oDataTable;
        }
    }
}

