using NUnit.Framework;
using System;
using System.Linq;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using CreditCardValidation.UITest.Pages;
using System.Globalization;

namespace CreditCardValidation.UITest.Steps
{
    [Binding]
    public class CreditCardSteps
    {
        [Given(@"I enter a (.*) number creditcard number")]
        public void GivenIEnterANumberCreditcardNumber(int lengthOfCreditcardNumber)
        {
            var page = new MainPage().WaitForPage(30) as MainPage;
            page.EnterCreditcardNumer(lengthOfCreditcardNumber);

            Base.App.Screenshot(string.Format(CultureInfo.InvariantCulture, "I enter a {0} number creditcard number", lengthOfCreditcardNumber));
        }

        [When(@"I press validate")]
        public void WhenIPressValidate()
        {
            var page = new MainPage().WaitForPage(30) as MainPage;
            page.PressValidate();

            Base.App.Screenshot(string.Format(CultureInfo.InvariantCulture, "I press validate"));
        }

        [Then(@"I should see the succes message")]
        public void ThenIShouldSeeTheSuccesMessage()
        {
            new ValidCreditcardPage().WaitForPage(30);

            Base.App.Screenshot(string.Format(CultureInfo.InvariantCulture, "I should see the succes message"));
        }
    }
}
