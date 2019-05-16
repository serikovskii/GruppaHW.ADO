using System.Configuration;
using System.Data.Common;

namespace HW.Gruppa.ADO.DataAccess
{
    public class DataService
    {
        private readonly string _connectionString;

        private readonly DbProviderFactory _providerFactory;

        public DataService()
        {
            _providerFactory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["ConnectionString"].ProviderName);
            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public void CreateTable()
        {
            using (var connection = _providerFactory.CreateConnection())
            using (var command = connection.CreateCommand())
            {
                connection.ConnectionString = _connectionString;
                connection.Open();
                command.CommandText = @"CREATE TABLE [dbo].[Table] ( [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), [Name] NVARCHAR(50) NOT NULL)";
                command.ExecuteNonQuery();
            }
        }
    }
}
