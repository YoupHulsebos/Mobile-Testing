using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.iOS;

namespace CreditCardValidation.UITest
{
    public static partial class Base
    {
        [BeforeFeature]
        public static void SetUp()
        {
			try
			{

	            string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
	            FileInfo fi = new FileInfo(currentFile);
	            string dir = fi.Directory.Parent.Parent.Parent.FullName;

	            string PathToIPA = Path.Combine(dir, "CreditCardValidation.iOS", "bin", "iPhoneSimulator", "Debug", "CardValidationiOS.app");

	            App = ConfigureApp.iOS.AppBundle(PathToIPA).StartApp();
			}
			catch(Exception ex) {
				string.Format("", ex);
				throw;
			}
        }
    }
}
