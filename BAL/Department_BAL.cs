using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Ref;

namespace BAL
{
    public class Department_BAL
    {

        public DataTable LoadAllDepartment(DB_Handler oDB_Handle)
        {
            DAL_Department oDepartment_DL = new DAL_Department();
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
                oDataTable = oDepartment_DL.LoadAllDepartment(oDB_Handle);
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
        public DataTable LoadUSINGIDDepartment(Department_Ref oDepartment_Ref, DB_Handler oDB_Handle)
        {
            DAL_Department oDepartment_DL = new DAL_Department();
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
                oDataTable = oDepartment_DL.LoadUSINGIDDepartment(oDepartment_Ref,oDB_Handle);
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

        public DataTable InsertDepartment(Department_Ref oDepartment_Ref, DB_Handler oDB_Handle)
        {
            DAL_Department oDepartment_DL = new DAL_Department();
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
                oDataTable = oDepartment_DL.InsertDepartment(oDepartment_Ref, oDB_Handle);
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
        public DataTable DeleteDepartment(Department_Ref oDepartment_Ref, DB_Handler oDB_Handle)
        {
            DAL_Department oDepartment_DL = new DAL_Department();
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
                oDataTable = oDepartment_DL.DeleteDepartment(oDepartment_Ref, oDB_Handle);
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
        public DataTable UpdateDepartment(Department_Ref oDepartment_Ref, DB_Handler oDB_Handle)
        {
            DAL_Department oDAL_Department = new DAL_Department();
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
                oDataTable = oDAL_Department.UpdateDepartment(oDepartment_Ref, oDB_Handle);
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