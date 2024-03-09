using Microsoft.Data.SqlClient;
using System.Data;


namespace ITI.DataAccessLayer.Data
{
    public class ApplicationDBContext
    {
        static string conStr = ITI.DataAccessLayer.AppSettings.Default.conStr;

        public static DataTable Select(string cmdText)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand selectCmd = new SqlCommand(cmdText, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                return dataTable;
            }
        }

        public static T GetById<T>(string query)
        {
            T lst = Activator.CreateInstance<T>();

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand selectCmd = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var propertyName = reader.GetName(i);
                            var property = typeof(T).GetProperty(propertyName);
                            if (property != null && reader[propertyName] != DBNull.Value)
                            {
                                property.SetValue(lst, reader[propertyName]);
                            }
                        }
                    }
                }
            }
            return lst;
        }


        // Execute Non Query
        // Create - Update - Delete
        public static int ExecuteNonQuery(string cmdText)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand command = new SqlCommand(cmdText, connection);

                connection.Open();

                return command.ExecuteNonQuery();
            }
        }
    }
}
