require 'calabash-cucumber/ibase'

class MainPage < Calabash::IBase

  def trait
    "* text:'Credit Card Validation'"
  end

  def enter_creditcard_number(number)
    touch("* marked:'CreditCardTextField'")
    keyboard_enter_text(number)
  end

  def validate
    touch("* marked:'ValidateButton'")
  end
end
