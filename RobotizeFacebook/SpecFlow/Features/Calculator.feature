Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Create User
	Click  Create a Story at the top of your News Feed.
	Click Create a Photo Story to add a photo or video from your computer.
	Next to Your Story, you can click  audience selector (example: Notifications Public or  Friends) to choose who can see your story.

Scenario:  Add first post
		Given Create user is