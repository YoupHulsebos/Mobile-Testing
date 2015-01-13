# Running the samples

Make sure you have Ruby 1.9 or above installed (Ruby 2.0+ recommended).

Install bundler unless you already have it installed:

    gem install bundler

(or sudo gem install bundler)


Install gems in the `Gemfile`:

    bundle install

# iOS

To run the iOS tests, make sure Xcode 5.1 is installed with command line tools.

Run


    bundle exec cucumber -p ios

# Android

To run the Android tests, ensure a recent Android SDK is installed, and that

* environment variable `ANDROID_HOME` is set to point to the sdk folder, for example `/Users/krukow/android/adt/sdk`

Also make sure the project in Xamarin.UITest has generated a apk file. To create the APK file, select the menu option Build->Package, as shown in thefollowing screenshot:

![How to generate a apk package](http://developer.xamarin.com/guides/android/deployment,_testing,_and_metrics/publishing_an_application/part_1_-_preparing_an_application_for_release/Images/11.png)

Run

    bundle exec calabash-android run ..\Xamarin.UITest\CreditCardValidation.Droid\bin\\Release\CreditCardValidation.Droid-Signed.apk -p android --format html --out index.html -f pretty

