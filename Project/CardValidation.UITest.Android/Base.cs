using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace CreditCardValidation.UITest
{
    public static partial class Base
    {
        private const string _pathToApk = @"CreditCardValidation.Droid\bin\Release\CreditCardValidation.Droid-Signed.apk";

        [BeforeFeature]
        public static void SetUp()
        {
			try
			{
                string currentFile = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath;
                FileInfo fi = new FileInfo(currentFile);
                string dir = fi.Directory.Parent.Parent.Parent.FullName;

                string PathToAPK = Path.Combine(dir, _pathToApk);

                App = ConfigureApp
                    .Android
                    .ApkFile(PathToAPK)
				.StartApp();
			}
			catch(Exception ex) {
				string.Format ("", ex);
				throw;
			}
        }
    }
}
