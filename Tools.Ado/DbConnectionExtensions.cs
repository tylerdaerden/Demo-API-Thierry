using System.Data;
using System.Data.Common;
using System.Reflection;

namespace Tools.Ado
{
    public static class DbConnectionExtensions
    {
        public static int ExecuteNonQuery(this DbConnection dbConnection, string query, bool isStoredProcedure = false, object? parameters = null, DbTransaction? dbTransaction = null)
        {
            return ExecuteNonQueryAsync(dbConnection, query, isStoredProcedure, parameters, dbTransaction).Result;
        }

        public async static Task<int> ExecuteNonQueryAsync(this DbConnection dbConnection, string query, bool isStoredProcedure = false, object? parameters = null, DbTransaction? dbTransaction = null)
        {
            if (dbConnection.State is not ConnectionState.Open)
                throw new InvalidOperationException("Connection must be open...");

            using (DbCommand dbCommand = CreateCommand(dbConnection, query, isStoredProcedure, parameters, dbTransaction))
            {
                return await dbCommand.ExecuteNonQueryAsync();
            }                
        }

        public static object? ExecuteScalar(this DbConnection dbConnection, string query, bool isStoredProcedure = false, object? parameters = null, DbTransaction? dbTransaction = null)
        {
            return ExecuteScalarAsync(dbConnection, query, isStoredProcedure, parameters, dbTransaction).Result;
        }

        public async static Task<object?> ExecuteScalarAsync(this DbConnection dbConnection, string query, bool isStoredProcedure = false, object? parameters = null, DbTransaction? dbTransaction = null)
        {
            if (dbConnection.State is not ConnectionState.Open)
                throw new InvalidOperationException("Connection must be open...");

            using (DbCommand dbCommand = CreateCommand(dbConnection, query, isStoredProcedure, parameters, dbTransaction))
            {
                object? result = await dbCommand.ExecuteScalarAsync();
                return result is DBNull ? null : result;
            }
        }

        public static IEnumerable<TResult> ExecuteReader<TResult>(this DbConnection dbConnection, string query, Func<IDataRecord, TResult> selector, bool isStoredProcedure = false, object? parameters = null, DbTransaction? dbTransaction = null)
        {
            ArgumentNullException.ThrowIfNull(selector, nameof(selector));

            if (dbConnection.State is not ConnectionState.Open)
                throw new InvalidOperationException("Connection must be open...");

            using (DbCommand dbCommand = CreateCommand(dbConnection, query, isStoredProcedure, parameters, dbTransaction))
            {
                using (DbDataReader dataReader = dbCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        yield return selector(dataReader);
                    }
                }
            }
        }

        public async static IAsyncEnumerable<TResult> ExecuteReaderAsync<TResult>(this DbConnection dbConnection, string query, Func<IDataRecord, TResult> selector, bool isStoredProcedure = false, object? parameters = null, DbTransaction? dbTransaction = null)
        {
            ArgumentNullException.ThrowIfNull(selector, nameof(selector));

            if (dbConnection.State is not ConnectionState.Open)
                throw new InvalidOperationException("Connection must be open...");

            using (DbCommand dbCommand = CreateCommand(dbConnection, query, isStoredProcedure, parameters, dbTransaction))
            {
                using(DbDataReader dataReader = await dbCommand.ExecuteReaderAsync())
                {
                    while(dataReader.Read())
                    {
                        yield return selector(dataReader);
                    }
                }
            }
        }

        private static DbCommand CreateCommand(DbConnection dbConnection, string query, bool isStoredProcedure, object? parameters, DbTransaction? dbTransaction)
        {
            DbCommand dbCommand = dbConnection.CreateCommand();
            dbCommand.CommandText = query;
            
            if(dbTransaction is not null)
                dbCommand.Transaction = dbTransaction;

            if (isStoredProcedure)
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                IDataParameter returnValue = dbCommand.CreateParameter();
                returnValue.ParameterName = "ReturnValue";
                returnValue.Value = 0;
                returnValue.Direction = ParameterDirection.ReturnValue;
                dbCommand.Parameters.Add(returnValue);
            }

            if(parameters is not null)
            {
                Type type = parameters.GetType();

                foreach(PropertyInfo property in type.GetProperties().Where(p => p.CanRead))
                {
                    IDataParameter parameter = dbCommand.CreateParameter();
                    parameter.ParameterName = property.Name;
                    parameter.Value = property.GetValue(parameters, null) ?? DBNull.Value;
                    dbCommand.Parameters.Add(parameter);
                }
            }

            return dbCommand;
        }
    }
}