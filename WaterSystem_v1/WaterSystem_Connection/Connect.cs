using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Connection
{
    public static class Connect
    {
        #region connection variables
        private static string _connectionString = null;
        private static SqlConnection sqlDBConnection = null;
        #endregion

        public static void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static bool OpenConnection()
        {
            try
            { 
                if (sqlDBConnection == null)
                {
                    sqlDBConnection = new SqlConnection(_connectionString);
                }
                if (sqlDBConnection.State == ConnectionState.Closed)
                {
                    sqlDBConnection.Open();
                }
                if (sqlDBConnection.State == ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void CloseConnection()
        {
            if (sqlDBConnection != null)
            {
                if (sqlDBConnection.State == ConnectionState.Open)
                {
                    sqlDBConnection.Close();
                }
            }
        }

        public static bool checkConnection()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception) { return false; }
        }

        public static DataSet dlFill_Schema(string spname)
        {
            OpenConnection();
            DataSet ds = new DataSet();
            ds = ExecuteStoredProcedure(spname);
            CloseConnection();
            return (ds);
        }
        public static DataSet dlFill_Schema(SortedList<String, String> Parameters, string spname)
        {
            OpenConnection();
            DataSet ds = new DataSet();
            ds = ExecuteStoredProcedureWithParametersWithName(Parameters, spname);
            CloseConnection();
            return (ds);
        }
        public static DataSet dlFill(string spname)
        {
            OpenConnection();
            DataSet ds = new DataSet();
            ds = ExecuteStoredProcedure(spname);
            CloseConnection();
            return (ds);
        }

        public static DataSet dlFill1(List<String> paraname, List<String> parameterList, string spname)
        {
            OpenConnection();
            DataSet ds = new DataSet();
            ds = ExecuteStoredProcedureWithParametersWithName(paraname, parameterList, spname);
            CloseConnection();
            return (ds);
        }

        public static DataSet dlFill_combo_name(List<String> paraname, List<String> parameterList, string spname)
        {
            OpenConnection();
            DataSet ds = new DataSet();
            ds = ExecuteStoredProcedureWithParametersWithName(paraname, parameterList, spname);
            CloseConnection();
            return (ds);
        }
        public static DataSet dlFill1(List<string> para, string spname)
        {
            OpenConnection();
            DataSet ds = new DataSet();
            ds = ExecuteStoredProcedureWithParameters(para, spname);
            CloseConnection();
            return (ds);
        }
        public static DataSet dlFill_combo(List<string> para, string spname)
        {
            OpenConnection();
            DataSet ds = new DataSet();
            ds = ExecuteStoredProcedureWithParameters(para, spname);
            CloseConnection();
            return (ds);
        }

        public static DataSet ExecuteStoredProcedure_Schema(string spName)
        {

            bool connectionClosedAtStart = false;
            if (sqlDBConnection == null
                || sqlDBConnection.State == ConnectionState.Closed
                || sqlDBConnection.State == ConnectionState.Broken)
            {
                connectionClosedAtStart = true;
                OpenConnection();
            }
            SqlCommand sqlCommand = new SqlCommand(spName, sqlDBConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataset = new DataSet();
            sqlDataAdapter.FillSchema(dataset, SchemaType.Source);
            if (connectionClosedAtStart == true)
            {
                CloseConnection();
            }
            return dataset;
        }
        public static DataSet ExecuteStoredProcedure(string spName)
        {

            bool connectionClosedAtStart = false;
            if (sqlDBConnection == null
                || sqlDBConnection.State == ConnectionState.Closed
                || sqlDBConnection.State == ConnectionState.Broken)
            {
                connectionClosedAtStart = true;
                OpenConnection();
            }
            SqlCommand sqlCommand = new SqlCommand(spName, sqlDBConnection);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            if (connectionClosedAtStart == true)
            {
                CloseConnection();
            }
            return dataset;
        }
        public static DataSet ExecuteStoredProcedureWithParameters(List<String> parameterList, string spName)
        {
            OpenConnection();
            //bool connectionStatus = true;
            //DataSet dataset = null;
            String query = "execute " + spName + " N'";
            for (int i = 0; i < parameterList.Count; i++)
            {
                query = query + parameterList[i] + "', N'";
            }

            query = (query.Trim().Remove(query.Length - 4)) + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlDBConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);

            //int rows = Convert.ToInt16(sqlCommand.ExecuteNonQuery());
            CloseConnection();
            return dataset;
        }
        public static DataSet ExecuteStoredProcedureWithParametersWithName(List<String> paraname, List<String> parameterList, string spName)
        {
            OpenConnection();
            //bool connectionStatus = true;
            //DataSet dataset = null;
            String query = "execute " + spName + " ";
            for (int i = 0; i < parameterList.Count; i++)
            {
                query = query + paraname[i] + "=N'" + parameterList[i] + "',";
            }
            query = (query.Trim().Remove(query.Length - 1)) + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlDBConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);

            //int rows = Convert.ToInt16(sqlCommand.ExecuteNonQuery());
            CloseConnection();
            return dataset;
        }
        public static DataSet ExecuteStoredProcedureWithParametersWithName(SortedList<String, String> Parameters, string spName)
        {
            OpenConnection();
            //bool connectionStatus = true;
            //DataSet dataset = null;
            String query = "execute " + spName + " ";
            foreach (KeyValuePair<string, string> k in Parameters)
            {
                query = query + k.Key.ToString() + "=N'" + k.Value.ToString() + "',";
            }
            query = (query.Trim().Remove(query.Length - 1)) + "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlDBConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);

            //int rows = Convert.ToInt16(sqlCommand.ExecuteNonQuery());
            CloseConnection();
            return dataset;
        }
        public static DataSet ExecuteStoredProcedureWithParametersWithName(Dictionary<String, String> Parameters, string spName)
        {
            OpenConnection();
            String query = string.Format("execute {0}", spName);
            foreach (KeyValuePair<string, string> k in Parameters)
            {
                GetProcedureParameter(k, ref query);
            }
            query = (query.Trim().Remove(query.Length - 1)) + "";

            SqlCommand sqlCommand = new SqlCommand(query, sqlDBConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataset = new DataSet();
            sqlDataAdapter.Fill(dataset);
            CloseConnection();
            return dataset;
        }

        private static void GetProcedureParameter(KeyValuePair<string, string> parameter, ref string query)
        {
            if (string.IsNullOrEmpty(parameter.Value))
            {
                query = string.Format("{0} {1} =null,", query, parameter.Key.ToString());
            }
            else
            {
                query = string.Format("{0} {1} =N'{2}',", query, parameter.Key.ToString(), parameter.Value.ToString());
            }
        }

        #region For Inline Query
        public static DataSet ExecuteQuery(Dictionary<string, string> Parameter, string Query)
        {
            DataSet dataset = new DataSet();
            try
            {
                if (OpenConnection())
                {
                    SqlCommand Command = new SqlCommand();
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = sqlDBConnection;
                    SqlParameter param;
                    foreach (KeyValuePair<string, string> k in Parameter)
                    {
                        param = new SqlParameter();
                        param.ParameterName = k.Key.ToString();
                        param.Value = k.Value.ToString();
                        //param.DbType = DbType.String;
                        Command.Parameters.Add(param);
                    }
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataset);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                CloseConnection();
            }
            return dataset;
        }
        public static int ExecuteNonQuery(Dictionary<string, string> Parameter, string Query)
        {
            int ret = 0;
            try
            {
                if (OpenConnection())
                {
                    SqlCommand Command = new SqlCommand();
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = sqlDBConnection;
                    SqlParameter param;
                    foreach (KeyValuePair<string, string> k in Parameter)
                    {
                        param = new SqlParameter();
                        param.ParameterName = k.Key.ToString();
                        param.Value = k.Value.ToString();
                        //param.DbType = DbType.String;
                        Command.Parameters.Add(param);
                    }
                    ret = Command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return ret;
        }

        public static DataSet ExecuteQuery(string Query)
        {
            DataSet dataset = new DataSet();
            try
            {
                if (OpenConnection())
                {
                    SqlCommand Command = new SqlCommand();
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = sqlDBConnection;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = Command;
                    dataAdapter.Fill(dataset);
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                CloseConnection();
            }
            return dataset;
        }
        public static int ExecuteNonQuery(string Query)
        {
            int ret = 0;
            try
            {
                if (OpenConnection())
                {
                    SqlCommand Command = new SqlCommand();
                    Command.CommandText = Query;
                    Command.CommandType = CommandType.Text;
                    Command.Connection = sqlDBConnection;
                    ret = Command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return ret;
        }

        #endregion


    }
}
