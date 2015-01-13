using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace CreditCardValidation.UITest
{
    [Binding]
    public static partial class Base
    {
        public static IApp App { get; set; }
    }
}
