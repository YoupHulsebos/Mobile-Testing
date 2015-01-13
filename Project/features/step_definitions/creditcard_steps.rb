
Given(/^I enter a (\d+) number creditcard number$/) do |lengthOfCreditcardNumber|
  @current_page = page(MainPage).await(timeout: 30)

  cardnumber = ""
  while(cardnumber.length < lengthOfCreditcardNumber.to_i)
    cardnumber = "#{cardnumber}9"
  end

  @current_page.enter_creditcard_number(cardnumber)
end

When(/^I press validate$/) do
  @current_page = page(MainPage).await(timeout: 30)
  @current_page.validate
end

Then(/^I should see the succes message$/) do
  @current_page = page(ValidCreditcardPage).await(timeout: 30)
end


Then(/^I should see that the number is to short$/) do
  @current_page = page(MainPage).await(timeout: 30)
end