Feature: Full version

  @automatic
  Scenario: No buy button when already bought
    Given the user has bought the full version
    Then I should not see the buy button

  @automatic
  Scenario: buy button the user did not buy bought
    Given the user has not bought the full version
    Then I should see the buy button