using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace GoogleSearch
{
    [TestFixture]
    public class GoogleSearchTest
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private ReadOnlyCollection<IWebElement> searchResults;
        private IWebElement firstElement;
        private object Expectrdconditions;

        public GoogleSearchTest()
        {
            
        }

        [SetUp]
        public void Setup()
        {
            string path = "T:\\הנדסת תוכנה\\שנה ב\\קבוצה ב\\תלמידות\\פנינה פלם\\אוטומציה\\1\\GoogleSearch\\GoogleSearch\\drivers";
            driver = new ChromeDriver(path);
            driver.Manage().Window.Maximize();
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10)); // Initialize explicit wait
        }

        public void ClickByXpath(string XPath)
        {
            IWebElement elementXPath = driver.FindElement(By.XPath(XPath));
            elementXPath.Click();
        }

        public void ClickByID(string ID)
        {
            IWebElement elementID = driver.FindElement(By.Id(ID));
            elementID.Click();
        }

        public void ClickByClass(string Class)
        {
            IWebElement elementClass = driver.FindElement(By.ClassName(Class));
            elementClass.Click();
        }


        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/alerts");

            ClickByID("timerAlertButton");

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));

            wait.Until()
            //IAlert alert = WaitForAlert(driver, TimeSpan.FromSeconds(10));


            //Assert.AreEqual("Google", driver.Title);

            //IWebElement searchBox = driver.FindElement(By.Name("//*[@id=\"app\"]/div/div/div[2]/div/div[3]"));
            //searchBox.SendKeys("Selenium WebDriver");
            //searchBox.Submit();

            //IWebElement resultElements = driver.FindElement(By.Id("search"));
            ////wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.XPath(".//a"))));
            //searchResults = resultElements.FindElements(By.XPath(".//a"));
            //Assert.IsTrue(searchResults.Count() > 0);
            //searchResults[0].FindElement(By.TagName("h3")).Click();

        }



        [TearDown] 
        public void TearDown() 
        { 
            driver.Dispose();
        }

        public void GetTestData()
        {

        }
    }
}