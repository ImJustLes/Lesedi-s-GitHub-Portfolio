using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Text;

namespace PROG7311POEPART2.Controllers
{
    public class FarmerController : Controller
    {

        //Initialisations
        List<AgriEnergyLibrary> products = new List<AgriEnergyLibrary>();
        SqlConnection conString = SingletonConnectionString.Instance.GetConnection();
        AgriEnergyLibrary obj = new AgriEnergyLibrary();

        //Gets the view that allows a farmer to login
        public ActionResult FarmerLogin()
        {
            return View();
        }

        //Gets the view that allows the farmer to create a product.
        public ActionResult CreateProduct()
        {
            return View();
        }

        //Handles the logging in of a farmer.
        [HttpPost]
        public async Task<ActionResult> FarmerLogin(IFormCollection collection)
        {
            try
            {
                //Declerations
                string username = collection["txtUsername"];
                string password = collection["txtPassword"];

                //Used to check if an account exists
                Boolean accountChecker = false;

                using (SqlConnection con = conString)
                {
                    string strSelect = $"SELECT EmployeeUsername, FarmerUsername, UserPassword FROM RegisteredFarmers";
                    SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                    await con.OpenAsync();

                    using (SqlDataReader reader = await cmdSelect.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            //Checks if the usernames match
                            if (reader.GetString(1).Equals(username))
                            {
                                accountChecker = true;

                                //Hashes the inputted password
                                string passHash = obj.EncryptPass(password);

                                //If the password is correct, it will load the user into the farmer side of the website
                                if (reader.GetString(2).Equals(passHash))
                                {
                                    AgriEnergyLibrary.farmerName = username;
                                    AgriEnergyLibrary.empName = reader.GetString(0);
                                    return RedirectToAction("LoadProducts", "Farmer");
                                }
                            }
                        }

                        //If the account doesn't exist, this error message will pop-up
                        if (accountChecker == false)
                        {
                            TempData["LoginFalse"] = "Invalid login!";
                          
                        }
                        //If there are missing values, this error message will pop-up
                        else if (username.Equals("") && password.Equals(""))
                        {
                            TempData["LoginValues"] = "Please fill in the required information.";
                        }
                    }
                }

            }
            catch
            {
                //If there is an error, the main page will be re-initialised
                TempData["Error"] = "An error occured, please try again.";
                return View();
            }
            //Re-initisalizes the register and login page by default.
            return View();
        }

        //Loads all the products of the farmer that has logged in
        public async Task<ActionResult> LoadProducts()
        {
            //Initialising the object.
            products = new List<AgriEnergyLibrary>();

            //Gets all the products of a farmer from the database.
            products = obj.GetFarmerProducts();

            //If the farmer has no products, the following error will show.
            if (products.Count == 0)
            {
                TempData["AddProduct"] = "WELCOME! Consider making a new product";
            }  
            
            return View("ProductList", products);
        }     

        //Handles the creation of a product.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateProduct(IFormCollection collection)
        {
            //Declerations and initialisations.
            string prodName = collection["txtProdName"];
            string prodCategory = collection["txtCat"];
            DateTime prodDate = Convert.ToDateTime(collection["txtProdDate"]);
            List<string> prodNames = new List<string>();

            try
            {
                //If any of the fields are empty, the user will be shown the following error.
                if (prodName.Equals("") || prodCategory.Equals("") || collection["txtProdDate"].Equals(""))
                {
                    TempData["NoValues"] = "Please enter all the required fields.";
                    return View();
                }
                else
                {           
                    //If the product does not exist, the new product is made and inserted into the database.
                    if (!obj.GetProductNames().Contains(prodName))
                    {
                        obj.InsertIntoEmployeeFarmers(prodName, prodCategory, prodDate);
                    }
                    else
                    {
                        TempData["DupProduct"] = "This product already exists.";
                    }
                    return View();
                }
            }           
            catch
            { 
                return View();
            }
        }
    }
}
