using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SnappetChallange.Steps
{
        [Binding]
        public class BaseStep
        {
            public static IWebDriver Driver { get; private set; }

            [BeforeScenario("UI")]
            public static void BeforeScenario()
            {
                PrepareEnvironment();
            }

            [AfterScenario("UI")]
            public static void AfterScenario()
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
