using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumSoftwareDevA2
{
    internal class DeletingExistingUserAccount
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
            email.SendKeys("JD@mail.com");

            //Passowrd
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("Password123!");

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

        //***LOCATE DELETE ACCOUNT BUTTON
            //Click delete account
            IWebElement deleteButton = driver.FindElement(By.Id("deleteAccount"));
            deleteButton.Click();

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }


    }
}
