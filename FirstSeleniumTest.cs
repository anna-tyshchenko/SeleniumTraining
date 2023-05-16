using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        
        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.CssSelector("[name=q]")).SendKeys("Selenium");
        }
    }
}