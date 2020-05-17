Feature: Flash exercise
	
@UI @FlashExercise
Scenario: As a PO, I would like see correct status when correct answers are given
	Given I have clicked the "pink box"
	And I have entered "Hello world." in the text input field
	And I have selected radio button number "1" with label "Correct"
	And I have selected checkbox number "1" with label "Correct"
	And I have selected checkbox number "3" with label "Correct"
	When I press to check my result
	Then the exercise status should be "Correct"
