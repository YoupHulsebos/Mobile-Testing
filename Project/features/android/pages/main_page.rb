require 'calabash-android/abase'

class MainPage < Calabash::ABase

  def trait
    "android.widget.TextView text:'Validate Credit Card'"
  end

  def enter_creditcard_number(number)
    enter_text("* marked:'creditCardNumberText'", number)
  end

  def validate
    touch("* marked:'validateButton'")
  end
end
