using CreditCardValidation.UITest;
using CreditCardValidation.UITest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace CreditCardValidation.UITest.Pages
{
    public class MainPage : AbstractPage, IMainPage
    {
        private Func<AppQuery, AppQuery> CreditCardNumberView { get { return c => c.Id("creditCardNumberText"); } }
        private Func<AppQuery, AppQuery> ValidateButton { get { return c => c.Id("validateButton"); } }

        public MainPage()
        {
            Trait = c => c.Text("Validate Credit Card");
        }

        public void EnterCreditcardNumer(int lengthOfCreditcardNumber)
        {
            Base.App.EnterText(CreditCardNumberView, new string('9', lengthOfCreditcardNumber));
        }

        public void PressValidate()
        {
            Base.App.Tap(ValidateButton);
        }
    }
}
