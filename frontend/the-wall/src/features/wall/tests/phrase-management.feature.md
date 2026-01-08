# Covers: 
# User Story 2.1 – Publish a phrase
# User Story 2.2 – View the wall
---

## Feature: Phrase management

    In order to share ideas on the wall
    As a user 
    I want to publish and view phrases

### Scenario: Publish a phrase from the wall

  Given the wall page is open
  And the publish phrase form is displayed
  When the user submits a phrase with text and style
  Then the wall is refreshed
  And the new phrase is displayed prominently
