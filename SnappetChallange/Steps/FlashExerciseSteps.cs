using SnappetChallange.Pages;
using SnappetChallange.Steps;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;
using System.Drawing.Text;

namespace SnappetChallange.Steps
{
    [Binding]
    class FlashExerciseSteps : BaseStep
    {
        [BeforeScenario("FlashExercise")]
        public static void BeforeFlashExercise()
        {
            Driver.Navigate().GoToUrl("https://exercise-player.snappet.org/exercise/2826229");
        }

        [Given(@"I have clicked the ""(.*)""")]
        public void GivenIHaveClickedThe(string hitBoxType)
        {
            FlashExercisePage flashExercisePage = new FlashExercisePage(Driver);
            flashExercisePage.HitBox(hitBoxType).Click();
        }


        [Given(@"I have entered ""(.*)"" in the text input field")]
        public void GivenIHaveEnteredInTheTextInputField(string textInput)
        {
            FlashExercisePage flashExercisePage = new FlashExercisePage(Driver);
            flashExercisePage.TextInput().SendKeys(textInput);
        }

        [Given(@"I have selected radio button number ""(.*)"" with label ""(.*)""")]
        public void GivenIHaveSelectedRadioButtonNumberWithText(int radioButtonNumber, string radionButtonLabel)
        {
            FlashExercisePage flashExercisePage = new FlashExercisePage(Driver);
            flashExercisePage.RadioButton(radioButtonNumber).Click();
        }

        [Given(@"I have selected checkbox number ""(.*)"" with label ""(.*)""")]
        public void GivenIHaveSelectedCheckboxNumberWithText(int checkBoxNumber, string checkBoxLabel)
        {
            FlashExercisePage flashExercisePage = new FlashExercisePage(Driver);
            flashExercisePage.CheckBox(checkBoxNumber).Click();
        }

        [When(@"I press the result check button to check my result")]
        public void WhenIPressToCheckMyResult()
        {
            FlashExercisePage flashExercisePage = new FlashExercisePage(Driver);
            flashExercisePage.CheckResultButton().Click();
        }

        [Then(@"the exercise status should be ""(.*)""")]
        public void ThenTheResultStatusShouldBe(string exerciseStatus)
        {
            FlashExercisePage flashExercisePage = new FlashExercisePage(Driver);
            Assert.That(flashExercisePage.ExerciseStatus().ToString(), Is.EqualTo(exerciseStatus));
        }

        [Then(@"the exercise hint should be ""(.*)""")]
        public void ThenTheExerciseHintShouldBe(string exerciseHint)
        {
            FlashExercisePage flashExercisePage = new FlashExercisePage(Driver);
            Assert.That(flashExercisePage.ExerciseHint().ToString(), Is.EqualTo(exerciseHint));
        }


    }
}
