# Covers: 
# User Story 2.1 – Publish a phrase
# User Story 2.2 – View the wall

Feature: Phrase management

    In order to share ideas on the wall
    As a user 
    I want to publish and view phrases

    Scenario: Publish a phrase successfully
    Given an authenticated user 
    And a valid phrase with a style (font, font size and color) 
    When the user publish the phrase
    Then it becomes visible to all users
    And it is associated with the posting user
    And the user’s name or alias is displayed
    And the phrase appears on the wall.
