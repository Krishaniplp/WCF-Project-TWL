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
   public class Status_BAL
    {
        public DataTable LoadAllStatus(DB_Handler oDB_Handle)
        {
            DAL_Status oStatus_DL = new DAL_Status();
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
                oDataTable = oStatus_DL.LoadAllStatus(oDB_Handle);
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
