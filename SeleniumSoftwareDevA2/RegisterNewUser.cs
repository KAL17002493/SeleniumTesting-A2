using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSoftwareDevA2
{
    public class Tests
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

        //Register new user successfully
        [Test]
        public void registerUser()
        {
            //Navigate to web page
            driver.Navigate().GoToUrl("http://localhost/SoftwareDevA2/A2/valid/");

            //Click on navbar toggle
            IWebElement navToggle = driver.FindElement(By.ClassName("navbar-toggler"));
            navToggle.Click();

            System.Threading.Thread.Sleep(5000);
            //Click login button
            IWebElement signIn = driver.FindElement(By.Id("loginButton"));
            signIn.Click();

            //Click register button
            IWebElement register = driver.FindElement(By.Id("register"));
            register.Click();

            //Register Form
            //Name
            IWebElement fname = driver.FindElement(By.Id("fname"));
            fname.SendKeys("John");

            //Surname
            IWebElement sname = driver.FindElement(By.Id("sname"));
            sname.SendKeys("Doe");

            //Email
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("JD@mail.com");

            //Passowrd
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("Qwe123!");

            //Password-v
            IWebElement passwordV = driver.FindElement(By.Id("password-v"));
            passwordV.SendKeys("Qwe123!");

            //Click register button to register new user
            IWebElement registerButton = driver.FindElement(By.Id("registerButton"));
            registerButton.Click();
        }

        [OneTimeTearDown]
        public void Clean()
        {
            driver.Close();
        }
    }
}