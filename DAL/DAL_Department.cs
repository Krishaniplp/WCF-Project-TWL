using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ref;

namespace DAL
{
    public class DAL_Department
    {
        public DataTable LoadAllDepartment(DB_Handler oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_GET_Department";
                oSqlCommand = new SqlCommand();

                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable LoadUSINGIDDepartment(Department_Ref oDepartment_Ref ,DB_Handler oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_USINGID_Department";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@DeptId", oDepartment_Ref.Dept_Id);
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable InsertDepartment(Department_Ref oDepartment_Ref, DB_Handler oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_UPDATE_Department";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@Dept_Id", oDepartment_Ref.Dept_Id);
                oSqlCommand.Parameters.AddWithValue("@Dept_Name", oDepartment_Ref.Dept_Name);
                oSqlCommand.Parameters.AddWithValue("@Dept_Status", oDepartment_Ref.Dept_Status);
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable DeleteDepartment(Department_Ref oDepartment_Ref, DB_Handler oDB_Handle)
        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_DELETE_Department";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@DeptId", oDepartment_Ref.Dept_Id);
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable UpdateDepartment(Department_Ref oDepartment_Ref, DB_Handler oDB_Handle)

        {
            string sqlQuery;
            DataTable oDataTable = new DataTable();
            SqlCommand oSqlCommand;
            SqlDataAdapter oSqlDataAdapter;
            try
            {
                sqlQuery = "SP_UPDATE_Department";
                oSqlCommand = new SqlCommand();
                oSqlCommand.Parameters.AddWithValue("@DeptId", oDepartment_Ref.Dept_Id);
                oSqlCommand.Parameters.AddWithValue("@DeptName", oDepartment_Ref.Dept_Name);
                oSqlCommand.Parameters.AddWithValue("@DeptStatus", oDepartment_Ref.Dept_Status);
                oSqlCommand.CommandText = sqlQuery;
                oSqlCommand.CommandType = CommandType.StoredProcedure;
                oSqlCommand.Connection = oDB_Handle.GetConnection();
                oSqlCommand.Transaction = oDB_Handle.GetTransaction();
                oSqlDataAdapter = new SqlDataAdapter(oSqlCommand);
                oSqlDataAdapter.Fill(oDataTable);

                return oDataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
