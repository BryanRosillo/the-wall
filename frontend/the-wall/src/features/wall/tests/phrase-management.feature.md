# Covers: 
# User Story 2.1 – Publish a phrase
# User Story 2.2 – View the wall
---

## Feature: Phrase management

    In order to share ideas on the wall
    As a user 
    I want to publish and view phrases

### Scenario: Display loading state while phrases are being loaded

  Given the user opens the wall page
  When phrases are being fetched
  Then a loading indicator is displayed

### Scenario: Display phrases on the wall

  Given the wall page is open
  And phrases have been loaded
  Then a list of phrases is displayed on the wall

### Scenario: Publish a phrase from the wall

  Given the wall page is open
  And the publish phrase form is displayed
  When the user submits a phrase with text and style (font, fontsize and color)
  Then the wall is refreshed
  And the new phrase is displayed prominently

