using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Reflection;
using System.Xml.Linq;

namespace PROG7311POEPART2
{
    public class AgriEnergyLibrary
    {
        //Declerations
        public static string empName { get; set; }
        public static string farmerName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string prodName { get; set; }
        public string prodCategory { get; set; }
        public DateTime prodDate { get; set; }

        //Singleton class instance for the connection string
        SqlConnection conString = SingletonConnectionString.Instance.GetConnection();

        //Default constructor
        public AgriEnergyLibrary() { }

        /// <summary>
        /// Consturctor for saving products.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="productName"></param>
        /// <param name="category"></param>
        /// <param name="prodDate"></param>
        public AgriEnergyLibrary(string username, string productName, string category, DateTime prodDate)
        {
            this.username = username;
            prodName = productName;
            prodCategory = category;
            this.prodDate = prodDate;
        }

        /// <summary>
        /// Constructor for displaying the farmers for the employee.
        /// </summary>
        /// <param name="username"></param>
        public AgriEnergyLibrary(string username) => this.username = username;


        /// <summary>
        /// Returns a list of all the usernames of all the employees.
        /// </summary>
        /// <returns></returns>
        public List<string> GetUsernames()
        {
            List<string> usernames = new List<string>();

            using (SqlConnection con = conString)
            {
                con.Open();

                //Select statement
                string strSelect = $"SELECT Username FROM RegisteredEmployees";
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {

                    //Uses while loop to input information from the database into the list.
                    while (reader.Read())
                    {
                        usernames.Add((string)reader[0]);
                    }
                }
            }
            return usernames;
        }

        /// <summary>
        /// Inserts the newly registered employee into the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void InsertIntoEmployeeRegister(string username, string password)
        {
            conString = SingletonConnectionString.Instance.GetConnection();

            //Select statement
            string strInsert = $"INSERT INTO RegisteredEmployees(Username, UserPassword) VALUES('{username}', '{EncryptPass(password)}')";

            using (SqlConnection con = conString)
            {
                con.Open();

                SqlCommand cmdInsert = new SqlCommand(strInsert, con);
                cmdInsert.ExecuteNonQuery();

            }
        }    

        /// <summary>
        /// Returns all the names of the farmers under a specific employee.
        /// </summary>
        /// <returns></returns>
        public List<AgriEnergyLibrary> GetFarmerUsernames() 
        {
            List<AgriEnergyLibrary> usernames = new List<AgriEnergyLibrary>();

            using (SqlConnection con = conString)
            {
                string strSelect = $"SELECT EmployeeUsername, FarmerUsername FROM RegisteredFarmers";
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                con.Open();

                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Checks if the usernames match
                        if (reader.GetString(0).Equals(AgriEnergyLibrary.empName))
                        {
                            usernames.Add(new AgriEnergyLibrary(reader.GetString(1)));
                        }
                    }
                }
            }
            return usernames;
        }

        /// <summary>
        /// Returns a list of all products from all employees under a specific employee.
        /// </summary>
        /// <returns></returns>
        public List<AgriEnergyLibrary> GetEmployeeFarmerProducts()
        {
            conString = SingletonConnectionString.Instance.GetConnection();
            List<AgriEnergyLibrary> EmployeeFarmerProducts = new List<AgriEnergyLibrary>();

            using (SqlConnection con = conString)
            {
                string strSelect = $"SELECT Username, FarmerUsername, ProductName, Category, ProductDate FROM EmployeeFarmers";
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                con.Open();

                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //Checks if the usernames match
                        if (reader.GetString(0).Equals(AgriEnergyLibrary.empName))
                        {
                            EmployeeFarmerProducts.Add(new AgriEnergyLibrary(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4)));
                        }
                    }
                }
            }
            return EmployeeFarmerProducts;
        }

        /// <summary>
        /// Returns a list of all the farmer's usernames.
        /// </summary>
        /// <returns>List of type string</returns>
        public List<string> GetAllFarmerUsernames()
        {
            conString = SingletonConnectionString.Instance.GetConnection();
            List<string> usernames = new List<string>();

            using (SqlConnection con = conString)
            {
                con.Open();

                //Select statement
                string strSelect = $"SELECT FarmerUsername FROM RegisteredFarmers";
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    //Uses while loop to input information from the database into the list.
                    while (reader.Read())
                    {
                        usernames.Add((string)reader[0]);
                    }
                }
            }
            return usernames;
        }

        /// <summary>
        /// Inserts the newly registered farmer into the database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void InsertIntoRegisteredFarmers(string username, string password)
        {
            conString = SingletonConnectionString.Instance.GetConnection();

            //Select statement
            string strInsert = $"INSERT INTO RegisteredFarmers(EmployeeUsername, FarmerUsername, UserPassword) VALUES('{AgriEnergyLibrary.empName}', '{username}', '{EncryptPass(password)}')";

            using (SqlConnection con = conString)
            {
                con.Open();

                SqlCommand cmdInsert = new SqlCommand(strInsert, con);
                cmdInsert.ExecuteNonQuery();
            }
        }       

        /// <summary>
        /// Returns a list of all the names of the products currently made.
        /// </summary>
        /// <returns>List of type string</returns>
        public List<string> GetProductNames()
        {
            conString = SingletonConnectionString.Instance.GetConnection();
            List<string> productNames = new List<string>();          

            using (SqlConnection con = conString)
            {
                string strSelect = $"SELECT ProductName FROM EmployeeFarmers";
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                con.Open();

                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productNames.Add(reader.GetString(0));
                    }
                }
                return productNames;
            }
        }

        /// <summary>
        /// Inserts the newly made product into the database.
        /// </summary>
        /// <param name="prodName"></param>
        /// <param name="prodCategory"></param>
        /// <param name="prodDate"></param>
        public void InsertIntoEmployeeFarmers(string prodName, string prodCategory, DateTime prodDate)
        {
            conString = SingletonConnectionString.Instance.GetConnection();
            string strInsert = $"INSERT INTO EmployeeFarmers(Username, FarmerUsername, ProductName, Category, ProductDate) VALUES('{AgriEnergyLibrary.empName}', '{AgriEnergyLibrary.farmerName}', '{prodName}', '{prodCategory}', '{prodDate.ToString("yyyy-MM-dd")}')";

            using (SqlConnection con = conString)
            {
                con.Open();

                SqlCommand cmdInsert = new SqlCommand(strInsert, conString);
                cmdInsert.ExecuteNonQuery();
            }               
        }

        /// <summary>
        /// Returns a list of all the products of a specific farmer.
        /// </summary>
        /// <returns>List of type AgriEnergyLibrary</returns>
        public List<AgriEnergyLibrary> GetFarmerProducts()
        {
            List<AgriEnergyLibrary> farmerProducts = new List<AgriEnergyLibrary>();

            using (SqlConnection con = conString)
            {
                string strSelect = $"SELECT FarmerUsername, ProductName, Category, ProductDate FROM EmployeeFarmers";
                SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                con.Open();

                using (SqlDataReader reader = cmdSelect.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        //Checks if the usernames match
                        if (reader.GetString(0).Equals(AgriEnergyLibrary.farmerName))
                        {
                            farmerProducts.Add(new AgriEnergyLibrary(AgriEnergyLibrary.farmerName, reader.GetString(1), reader.GetString(2), reader.GetDateTime(3)));
                        }
                    }
                }
            }
            return farmerProducts;
        }

        /// <summary>
        /// Returns a string that is an encrypted version of the inputted password.
        /// </summary>
        /// <param name="password"></param>
        /// <returns>String</returns>
        public string EncryptPass(string password) => Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
    }
}
