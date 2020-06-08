Feature: SpecFlowFeature
	In order to login in to facebook
	As a developer
	I want to validate facebook login

@Browser: Chrome
Scenario: facebook Login page
	Given I Navigate to the facebook Login page
	When I Login with Username 'nikita.shriram@ymail.com' and Password 'N9028563532n' as inputs
	Then I am on the facebook dashboard page
