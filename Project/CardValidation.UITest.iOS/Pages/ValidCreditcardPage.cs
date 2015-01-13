using CreditCardValidation.UITest;
using CreditCardValidation.UITest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardValidation.UITest.Pages
{
    public class ValidCreditcardPage : AbstractPage, IValidCreditcardPage
    {
        public ValidCreditcardPage()
        {
            Trait = c => c.Text("Valid Credit Card");
        }
    }
}
