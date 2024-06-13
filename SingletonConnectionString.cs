using System.Data.SqlClient;

namespace PROG7311POEPART2
{
    public class SingletonConnectionString
    {
        private SingletonConnectionString() { }

        //Decleration
        private static readonly Lazy<SingletonConnectionString> _instance =
            new Lazy<SingletonConnectionString>(() => new SingletonConnectionString());

        //Creates a value of the instance
        public static SingletonConnectionString Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        //Connection string for database.
        private string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PROG7311POEPART3;Integrated Security=True;Connect Timeout=30;Encrypt=False;";

        //Checks if theres an already made instance of the connection string.
        public string ConnectionString
        {
            get { return _connectionString; }
            private set
            {
                if (!string.IsNullOrEmpty(_connectionString))
                {
                    throw new InvalidOperationException("Connection string already set.");
                }
                _connectionString = value;
            }
        }

        /// <summary>
        /// Gets the initialised connection string
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public SqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("Connection string not set. Please initialize ConnectionString property before calling GetConnection.");
            }
            return new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Initialises the connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public void Initialize(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}

