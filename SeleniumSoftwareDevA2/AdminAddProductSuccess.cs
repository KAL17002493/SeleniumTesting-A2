using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumSoftwareDevA2
{
    internal class AdminAddProductSuccess
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

            //Click on navbar toggle
            IWebElement navToggle = driver.FindElement(By.ClassName("navbar-toggler"));
            navToggle.Click();

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

            //Click on navbar toggle
            IWebElement navToggle2 = driver.FindElement(By.ClassName("navbar-toggler"));
            navToggle2.Click();

        //***ADD PRODUCT NAVIGATION
            System.Threading.Thread.Sleep(1500);
            IWebElement addProduct = driver.FindElement(By.Id("addProduct"));
            addProduct.Click();

        //***ADD PRODUCT FORM

            //Name
            IWebElement name = driver.FindElement(By.Id("name"));
            name.SendKeys("Boat");

            //Desc
            IWebElement description = driver.FindElement(By.Id("description"));
            description.SendKeys("Test Boat");

            //Price
            IWebElement price = driver.FindElement(By.Id("price"));
            price.SendKeys("12.51");

            //Image
            IWebElement image = driver.FindElement(By.Id("image"));
            image.SendKeys("H:\\My Pictures\\47087295-texture-of-a-dark-stone-wall-seamless-background-.jpg");

            IWebElement addProductButton = driver.FindElement(By.Id("addProductButton"));
            addProductButton.Click();
        }
    }
}
