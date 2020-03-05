using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person_12345> People { get; set; }
        public DbSet<Car_12345> Cars { get; set; }

        public AppDbContext() : base("AppDbContext")
        {

        }

        public void Reset()
        {
            string className = nameof(Person_12345);

            #region Remove Tables
            string suffix = className.Split('_')[1];

            string connectionString = Database.Connection.ConnectionString;
            string commandText = "DECLARE @sql NVARCHAR(MAX) = N''; SELECT @sql += 'DROP TABLE ' + QUOTENAME(s.name) + '.' + QUOTENAME(t.name) + ';'FROM sys.tables AS t INNER JOIN sys.schemas AS s ON t.[schema_id] = s.[schema_id] WHERE t.name LIKE '%_" + suffix + "' OR t.name like '__MigrationHistory'; PRINT @sql; EXEC sp_executesql @sql; ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                conn.Open();
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (System.Exception)
                    {
                        // throw;
                    }
                }

                conn.Close();
            }
            #endregion

            Database.Initialize(true);
        }
    }
}
