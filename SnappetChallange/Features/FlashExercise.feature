@UI
Feature: Flash exercise
	
@FlashExercise @happyflow
Scenario: FE-01 As a PO, I would like see status is correct when correct answers are given
	Given I have clicked the "pink box"
	And I have entered "Hello world." in the text input field
	And I have selected radio button number "1" with label "Correct"
	And I have selected checkbox number "1" with label "Correct"
	And I have selected checkbox number "3" with label "Correct"
	When I press the result check button to check my result
	Then the exercise status should be "Correct"

@FlashExercise
Scenario: FE-02 As a PO, I would like see correct status hint when required text field is empty
	Given I have clicked the "pink box"
	And I have selected radio button number "1" with label "Correct"
	And I have selected checkbox number "1" with label "Correct"
	And I have selected checkbox number "3" with label "Correct"
	When I press the result check button to check my result
	Then the exercise status should be "Incorrect"
	And the exercise hint should be "required text empty"

@FlashExercise
Scenario: FE-03 As a PO, I would like see status is incorrect when incorrect text is entered as input
	Given I have clicked the "pink box"
	And I have entered "incorrect text" in the text input field
	And I have selected radio button number "1" with label "Correct"
	And I have selected checkbox number "1" with label "Correct"
	And I have selected checkbox number "3" with label "Correct"
	When I press the result check button to check my result
	Then the exercise status should be "Incorrect"

@FlashExercise
Scenario: FE-04 As a PO, I would like see status is incorrect when wrong radio button is selected
	Given I have clicked the "pink box"
	And I have entered "Hello world." in the text input field
	And I have selected radio button number "2" with label "Wrong"
	And I have selected checkbox number "1" with label "Correct"
	And I have selected checkbox number "3" with label "Correct"
	When I press the result check button to check my result
	Then the exercise status should be "Incorrect"

@FlashExercise
Scenario: FE-05 As a PO, I would like see status is incorrect when wrong hit box is selected
	Given I have clicked the "purple circle"
	And I have entered "Hello world." in the text input field
	And I have selected radio button number "1" with label "Correct"
	And I have selected checkbox number "1" with label "Correct"
	And I have selected checkbox number "3" with label "Correct"
	When I press the result check button to check my result
	Then the exercise status should be "Incorrect"

@FlashExercise
Scenario: FE-06 As a PO, I would like see status is incorrect when wrong checkbox is selected
	Given I have clicked the "purple circle"
	And I have entered "Hello world." in the text input field
	And I have selected radio button number "1" with label "Correct"
	And I have selected checkbox number "1" with label "Correct"
	And I have selected checkbox number "2" with label "Wrong"
	When I press the result check button to check my result
	Then the exercise status should be "Incorrect"
