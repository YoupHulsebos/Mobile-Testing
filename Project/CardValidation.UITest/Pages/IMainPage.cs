using System;

using Xamarin.UITest.Queries;

namespace CreditCardValidation.UITest.Pages
{
    public interface IMainPage : IPage
    {
        void EnterCreditcardNumer(int number);
        void PressValidate();
    }
}
