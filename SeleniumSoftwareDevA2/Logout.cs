using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumSoftwareDevA2
{
    internal class LoginExistingUser
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            //headless makes it so the test is done in the background (browser does not get opened)
            //options.AddArgument("--headless");

            driver = new ChromeDriver(@"C:\Users\KAL17002493\source\repos\SeleniumSoftwareDevA2\SeleniumSoftwareDevA2\chromedriver.exe", options);
        }

        //Login successfully with newly created account
        [Test]
        public void loginUser()
        {

            driver.Navigate().GoToUrl("http://localhost/SoftwareDevA2/A2/valid/");

            //Click on navbar toggle
            IWebElement navToggle = driver.FindElement(By.ClassName("navbar-toggler"));
            navToggle.Click();

            System.Threading.Thread.Sleep(5000);
            //Click login button
            IWebElement signIn = driver.FindElement(By.Id("loginButton"));
            signIn.Click();

            //Email
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("JD@mail.com");

            //Passowrd
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("Qwe123!");

            //Click register button to register new user
            IWebElement loginButton = driver.FindElement(By.Id("login"));
            loginButton.Click();


            //ASSERT

            //Click on navbar toggle
            IWebElement navToggle2 = driver.FindElement(By.ClassName("navbar-toggler"));
            navToggle2.Click();

            //Checks if login has succeeded
            IWebElement success = driver.FindElement(By.Id("logout"));
        }

        [OneTimeTearDown]
        public void Clean()
        {
            driver.Close();
        }
    }
}
