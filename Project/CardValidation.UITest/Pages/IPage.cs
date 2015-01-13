using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace CreditCardValidation.UITest.Pages
{
    public interface IPage
    {
        Func<AppQuery, AppQuery> Trait { get; set; }

        IPage WaitForPage(int timeToWait);
    }
}
