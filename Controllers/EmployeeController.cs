using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace PROG7311POEPART2.Controllers
{
    public class EmployeeController : Controller
    {
        //Declerations
        static List<AgriEnergyLibrary> farmers;
        static List<AgriEnergyLibrary> farmerProducts;
        List<AgriEnergyLibrary> products;
        AgriEnergyLibrary obj = new AgriEnergyLibrary();
        SqlConnection conString = SingletonConnectionString.Instance.GetConnection();

        //Gets the view that allows one to register as an employee
        public ActionResult EmployeeRegister()
        {
            return View();
        }

        //Gets the view that allows one to login as an employee
        public ActionResult EmployeeLogin()
        {
            return View();
        }

        //Gets the view that allows employees to create farmers
        public ActionResult CreateFarmer()
        {
            return View();
        }

        //Registers the employee
        [HttpPost]
        public ActionResult EmployeeRegister(IFormCollection collection)
        {
            try
            {
                //Declerations
                string username = collection["txtUsername"];
                string password = collection["txtPassword"];
                string password2 = collection["txtPassword2"];

                //If any of the fields are missing a value or has a default value, the user will be prompted with the error.
                if (username.Equals("") || password.Equals("") || password2.Equals(""))
                {
                    TempData["RegisterValues"] = "Fill in all the required values";
                    return View();
                }
                else
                {
                    //If the user already exists, the page will be reloaded with an error.
                    if (obj.GetUsernames().Contains(username))
                    {
                        TempData["RgeisterNameTaken"] = "User already exists!";
                        return View();
                    }
                    else
                    {
                        //If the passwords match, it will enter the if statement
                        if (password == password2)
                        {
                            obj.InsertIntoEmployeeRegister(username, password);
                            TempData["RegisterSuccess"] = "Register successful!";
                            return View();
                        }
                        else
                        {
                            //If the passwords do not match, the user will be prompted with this.
                            TempData["PasswordMatch"] = "The passwords don't match!";
                            return View();
                        }
                    }
                }
            }
            catch
            {
                //If there is an error, this error prompt will be shown
                TempData["Erorr"] = "An error occured, please try again.";
                return View();
            }
        }

        //Allows the employee to login the system.
        [HttpPost]
        public async Task<ActionResult> EmployeeLogin(IFormCollection collection)
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
                    //Select statement
                    string strSelect = $"SELECT * FROM RegisteredEmployees";
                    SqlCommand cmdSelect = new SqlCommand(strSelect, con);

                    await con.OpenAsync();

                    using (SqlDataReader reader = await cmdSelect.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            //Checks if the usernames match
                            if (reader.GetString(0).Equals(username))
                            {
                                accountChecker = true;

                                //Hashes the inputted password
                                string passHash = obj.EncryptPass(password);

                                //If the password is correct, it will load the user into the main part of the website
                                if (reader.GetString(1).Equals(passHash))
                                {
                                    AgriEnergyLibrary.empName = reader.GetString(0);
                                    return RedirectToAction("LoadFarmers", "Employee");
                                }
                            }
                        }

                        //If the account doesn't exist, this error message will pop-up
                        if (accountChecker == false)
                        {
                            TempData["LoginFalse"] = "Invalid login!";

                            //If there are missing values, this error message will pop-up
                        }
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
            //Re-initisalizes the page by default in case.
            return View();
        }

        //Loads all the farmers for the employee that logged in
        [HttpGet]
        public async Task<ActionResult> LoadFarmers()
        {
            //Initialises lists
            farmers = new List<AgriEnergyLibrary>();
            farmerProducts = new List<AgriEnergyLibrary>();

            //Returns a list of farmer names
            farmers = obj.GetFarmerUsernames();

            //If there are no existing farmers, the user will not enter the if statement
            if (farmers.Count == 0)
            {
                TempData["AddFarmer"] = "WELCOME! Consider registering a new farmer!";
            }
            else
            {
                farmerProducts = obj.GetEmployeeFarmerProducts();
            }
            return View("FarmerList", farmers);
        }       

        // POST: FarmerListController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateFarmer(IFormCollection collection)
        {
            try
            {
                //Declerations
                string username = collection["txtUsername"];
                string password = collection["txtPassword"];
                string password2 = collection["txtPassword2"];

                //If any of the fields are missing a value or has a default value, the user will be prompted with the error.
                if (username.Equals("") || password.Equals("") || password2.Equals(""))
                {
                    TempData["RegisterValues"] = "Fill in all the required values";
                    return View();
                }
                else
                {  
                    if (obj.GetAllFarmerUsernames().Contains(username))
                    {
                        TempData["RegisterNameTaken"] = "User already exists!";
                        return View();
                    }
                    else
                    {
                        //If the passwords match, it will enter the if statement
                        if (password == password2)
                        {
                            obj.InsertIntoRegisteredFarmers(username, password);
                            return RedirectToAction(nameof(LoadFarmers));                           
                        }
                        else
                        {
                            //If the passwords do not match, the user will be prompted with this.
                            TempData["PasswordMatch"] = "The passwords don't match!";
                            return View();
                        }
                    }
                }
            }
            catch
            {
                //If there is an error, this error prompt will be shown
                TempData["Error"] = "An error has occured. Please try again."; //(World, 2023)
                return View();
            }
        }

        //Allows the employee to view a specific farmer's products.
        public ActionResult ViewProducts(string id)
        {
            products = new List<AgriEnergyLibrary>();
            AgriEnergyLibrary.farmerName = id;

            foreach (AgriEnergyLibrary product in farmerProducts)
            {
                if (product.username.Equals(id))
                {
                    products.Add(product);
                }
            }

            //If the farmer hasn't made a product the employee will see the following error.
            if (products.Count == 0)
            {
                TempData["NoProduct"] = "This farmer has not yet made a product";
                return RedirectToAction("LoadFarmers");
            }
            else
            {
                return View("ViewProductsList", products);
            }          
        }

        //Allows the employee to filter the product of farmer by category.
        public ActionResult FilterProducts(IFormCollection collection) 
        {
            //Declerations and initilisations
            string category = collection["txtCat"];
            List<AgriEnergyLibrary> filteredProducts = new List<AgriEnergyLibrary>();

            //A loop that adds the products that are under a specific farmer and is of the category chosen by the employee.
            foreach (AgriEnergyLibrary product in farmerProducts)
            {
                if (product.username.Equals(AgriEnergyLibrary.farmerName) && product.prodCategory.Equals(category))
                {
                    filteredProducts.Add(product);
                }
            }

            //If the employee wants to see all the products of a farmer, this will display all the product.
            if (category.Equals("All"))
            {
                foreach (AgriEnergyLibrary product in farmerProducts)
                {
                    filteredProducts.Add(product);
                }
            }

            //If the farmer hasn't made a product, then the the following error will display.
            if (filteredProducts.Count == 0)
            {
                TempData["NoProduct"] = "This farmer has not yet made a product for this category";
                return View("ViewProductsList", filteredProducts);
            }
            else
            {
                return View("ViewProductsList", filteredProducts);
            }
        }
    }
}
