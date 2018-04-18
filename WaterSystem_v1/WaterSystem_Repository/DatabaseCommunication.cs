using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Connection;

namespace WaterSystem_Repository
{
    public class DatabaseCommunication
    {
        private string _connectionString = string.Empty;
        public DatabaseCommunication()
        {
            _connectionString = Database.Default.ConnectionString.ToString();
            SetConnection();
        }

        private void SetConnection()
        {
            Connect.SetConnection(_connectionString);
        }

        public bool connectedYN()
        {
            return (Connect.OpenConnection());
        }
        public bool checkConnection()
        {
            return (Connect.checkConnection() == true ? true : false);
        }

        public DataSet blFill(String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.dlFill(spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_With_Schema(String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.dlFill_Schema(spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_With_Schema(SortedList<String, String> Parameters, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.dlFill_Schema(Parameters, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_para(List<string> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.dlFill1(para, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Para_Name(List<String> paraname, List<String> parameterList, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.dlFill1(paraname, parameterList, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Para_Name(SortedList<String, String> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.ExecuteStoredProcedureWithParametersWithName(para, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Para_Name(Dictionary<String, String> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.ExecuteStoredProcedureWithParametersWithName(para, spname);
            }
            catch (Exception err)
            {
                throw new ArgumentException(string.Format("Store procedure error:{0}", spname), err);
            }
            return (ds);
        }
        public DataSet blFill_Combo(List<string> para, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.dlFill_combo(para, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }
        public DataSet blFill_Combo_name(List<string> para_name, List<string> para_value, String spname)
        {
            DataSet ds = new DataSet();
            try
            {
                ds = Connect.dlFill_combo_name(para_name, para_value, spname);
            }
            catch (Exception err)
            {
                err.GetBaseException();
            }
            return (ds);
        }


        public DataSet ExecuteQuery(Dictionary<string, string> Parameter, string Query)
        {
            return Connect.ExecuteQuery(Parameter, Query);
        }
        public int ExecuteNonQuery(Dictionary<string, string> Parameter, string Query)
        {
            return Connect.ExecuteNonQuery(Parameter, Query);
        }

        public DataSet ExecuteQuery(string Query)
        {
            return Connect.ExecuteQuery(Query);
        }
        public int ExecuteNonQuery(string Query)
        {
            return Connect.ExecuteNonQuery(Query);
        }
    }
}
