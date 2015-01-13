using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace CreditCardValidation.UITest.Pages
{
    public abstract class AbstractPage : IPage
    {
        public Func<AppQuery, AppQuery> Trait { get; set; }

        public IPage WaitForPage(int timeout)
        {
            Base.App.WaitForElement(Trait, timeout: new TimeSpan(0,0,timeout));
            return this;
        }
    }
}
