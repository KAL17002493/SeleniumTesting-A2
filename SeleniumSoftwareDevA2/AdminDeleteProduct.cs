using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSoftwareDevA2
{
    internal class AdminDeleteProduct
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

        //Login successfully with newly created account and logout after
        [Test]
        public void logoutUser()
        {
            
            driver.Navigate().GoToUrl("http://localhost/SoftwareDevA2/A2/valid/");
            driver.Manage().Window.Maximize();

            System.Threading.Thread.Sleep(1500);
            //Click login button
            IWebElement signIn = driver.FindElement(By.Id("loginButton"));
            signIn.Click();

            //Email
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("admin@admin.com");

            //Passowrd
            IWebElement password = driver.FindElement(By.Id("password"));
            password.SendKeys("Qwe123!");

            //Click login buttone
            IWebElement loginButton = driver.FindElement(By.Id("login"));
            loginButton.Click();

        //***ADD PRODUCT NAVIGATION
            System.Threading.Thread.Sleep(1500);
            IWebElement editProduct = driver.FindElement(By.Id("editProduct"));
            editProduct.Click();

            IWebElement scroll2 = driver.FindElement(By.TagName("body"));
            scroll2.SendKeys(Keys.PageDown);

            //***ADD PRODUCT NAVIGATION
            System.Threading.Thread.Sleep(1500);
            IWebElement chooseProduct = driver.FindElement(By.Id("productDelete3"));
            chooseProduct.Click();
        }
    }
}
