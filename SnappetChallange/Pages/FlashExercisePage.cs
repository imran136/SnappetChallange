using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing.Text;
using System.Threading;

namespace SnappetChallange.Pages
{
    class FlashExercisePage
    {
        private IWebDriver driver;
        private string hitBoxTypeSelector;

        public FlashExercisePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement TextInput()
        {
            By textInput = By.CssSelector("*[data-test=\"text-box\"]");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementToBeClickable(textInput));
        }

        public IWebElement RadioButton(int radioButtonNumber)
        {
            By radioButton = By.CssSelector(".ng-tns-c19-6:nth-child(" + radioButtonNumber + ") > .custom-control-label");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementToBeClickable(radioButton));
        }

        public IWebElement CheckBox(int checkBoxNumber)
        {
            By checkBox = By.CssSelector(".ng-tns-c19-7:nth-child(" + checkBoxNumber + ") > .custom-control-label");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementToBeClickable(checkBox));
        }

        public IWebElement CheckResultButton()
        {
            By checkResultButton = By.Id("check");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementToBeClickable(checkResultButton));
        }

        public String ExerciseStatus()
        {
            By exerciseStatus = By.Id("exercise_status");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementIsVisible(exerciseStatus)).Text;
        }

        public String ExerciseHint()
        {
            By exerciseHint = By.Id("exercise_hint");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementIsVisible(exerciseHint)).Text;
        }

        public IWebElement HitBox(string hitBoxType)
        {
            if (hitBoxType == "pink box")
                hitBoxTypeSelector = ".ng-tns-c17-12:nth-child(2) > .ng-star-inserted";
            else if (hitBoxType == "purple circle")
                hitBoxTypeSelector = ".ng-tns-c17-10:nth-child(2) > .ng-star-inserted";
            By hitBox = By.CssSelector(hitBoxTypeSelector);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(ExpectedConditions.ElementIsVisible(hitBox));
        }
    }
}
