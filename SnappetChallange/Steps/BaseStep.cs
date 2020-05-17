using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SnappetChallange.Steps
{
        [Binding]
        public class BaseStep
        {
            public static IWebDriver Driver { get; private set; }

            [BeforeFeature("UI")]
            public static void BeforeFeature()
            {
                PrepareEnvironment();
            }

            [AfterFeature("UI")]
            public static void AfterFeature()
            {
                CloseTests();
            }

            public static void PrepareEnvironment()
            {
                Driver = new ChromeDriver();
                Driver.Manage().Window.Maximize();
            }

            public static void CloseTests()
            {
                Driver?.Quit();
            }

        }    
}
