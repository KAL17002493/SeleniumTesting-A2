using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumSoftwareDevA2
{
    internal class ChangeExistingUserDeatils
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();

            driver = new ChromeDriver(@"C:\Users\KAL17002493\source\repos\SeleniumSoftwareDevA2\SeleniumSoftwareDevA2\chromedriver.exe", options);
        }

        //Edit user details
        [Test]
        public void loginUser()
        {
            driver.Navigate().GoToUrl("http://localhost/SoftwareDevA2/A2/valid/");

        //***LOGIN USER
            //Click on navbar toggle
            IWebElement navToggle = driver.FindElement(By.ClassName("navbar-toggler"));
            navToggle.Click();

            System.Threading.Thread.Sleep(1500);
            //Click login button
            IWebElement signIn = driver.FindElement(By.Id("loginButton"));
            signIn.Click();

            //Email
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("DJ@mail.com");

            //Passowrd
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("Qwe123!");

            //Click click on login button
            IWebElement loginButton = driver.FindElement(By.Id("login"));
            loginButton.Click();

        //***NAVIGATE TO USER DETAILS
            //Click on navbar toggle
            IWebElement navToggle2 = driver.FindElement(By.ClassName("navbar-toggler"));
            navToggle2.Click();

            System.Threading.Thread.Sleep(1500);
            //Click user button
            IWebElement user = driver.FindElement(By.Id("user"));
            user.Click();
            System.Threading.Thread.Sleep(1500);
            //***USER EDIT FORM
            //Name
            IWebElement fname = driver.FindElement(By.Id("firstname"));
            fname.SendKeys("Larrey");

            //Surname
            IWebElement sname = driver.FindElement(By.Id("lastname"));
            fname.SendKeys("Smith");

            //Email
            IWebElement emailU = driver.FindElement(By.Id("email"));
            //emailU.Clear();

            //Passowrd
            IWebElement passwordU = driver.FindElement(By.Id("password"));
            passwordU.SendKeys("Qwe123!");

            //Password-v
            IWebElement passwordUV = driver.FindElement(By.Id("password-v"));
            passwordUV.SendKeys("Qwe123!");

            //Click save details buttons
            IWebElement saveButton = driver.FindElement(By.Id("saveDetails"));
            saveButton.Click();
        }


    }
}
