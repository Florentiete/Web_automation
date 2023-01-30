using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Shopingas
{
    public class LoginForm
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void Test2()
        {

            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            var Button = driver.FindElement(By.Id("signin2"));
            Button.Click();

            var username = driver.FindElement(By.Id("sign-username"));
            var password = driver.FindElement(By.Id("sign-password"));
            var Button1 = driver.FindElement(By.XPath("(//button[@class='btn btn-primary'])[2]"));
            username.SendKeys("Kinderr");
            password.SendKeys("surprisee");
            Button1.Click();

            var alertText = driver.SwitchTo().Alert();
            Console.WriteLine(alertText.Text);

            Assert.That(alertText.Text, Is.EqualTo("Sign up successful."));
            driver.SwitchTo().Alert().Accept();

        }

    }
    public class LoginnForm
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]

        public void Test3()
        {

            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            var Button2 = driver.FindElement(By.Id("login2"));
            Button2.Click();

            var username1 = driver.FindElement(By.Id("loginusername"));
            var password1 = driver.FindElement(By.Id("loginpassword"));
            var Button3 = driver.FindElement(By.XPath("(//button[@class='btn btn-primary'])[3]"));
            username1.SendKeys("Kinderr");
            password1.SendKeys("surprisee");
            Button3.Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }







        [Test]

        public void Test4()
        {

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Laptops = driver.FindElement(By.LinkText("Laptops"));
            Laptops.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var Macbok = driver.FindElement(By.LinkText("MacBook air"));
            Macbok.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var Add = driver.FindElement(By.LinkText("Add to cart"));
            Add.Click();

            var alertText2 = driver.SwitchTo().Alert();
            Console.WriteLine(alertText2.Text);

            Assert.That(alertText2.Text, Is.EqualTo("Product added."));
            driver.SwitchTo().Alert().Accept();

            var button_cart = driver.FindElement(By.Id("cartur"));
            button_cart.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            var button_laptops = driver.FindElement(By.XPath("(//button[@class='btn btn-success'])[1]"));
            button_laptops.Click();

            var Name = driver.FindElement(By.Id("name"));
            var Country = driver.FindElement(By.Id("country"));
            var City = driver.FindElement(By.Id("city"));
            var Card = driver.FindElement(By.Id("card"));
            var Month = driver.FindElement(By.Id("month"));
            var Year = driver.FindElement(By.Id("year"));

            Name.SendKeys("Pirmas");
            Country.SendKeys("Lithuania");
            City.SendKeys("Kaunas");
            Card.SendKeys("1234");
            Month.SendKeys("04");
            Year.SendKeys("2025");


            var button_finish = driver.FindElement(By.XPath("(//button[@class='btn btn-primary'])[3]"));
            button_finish.Click();

            var alertText3 = driver.SwitchTo().Alert();
            Console.WriteLine(alertText3.Text);

            Assert.That(alertText3.Text, Is.EqualTo("OK"));
            driver.SwitchTo().Alert().Accept();

        }

    }
}
