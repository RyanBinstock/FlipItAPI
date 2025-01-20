using Microsoft.Data.Sqlite;

namespace FlipIt.API.EntityFramework
{
    public class SqlLiteConnectionPersistor : IDisposable
    {
        private readonly SqliteConnection connection;

        public SqlLiteConnectionPersistor()
        {
            connection = new SqliteConnection("DataSource=file:memdb1?mode=memory&cache=shared");
            connection.Open();
        }

        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }
    }
}
