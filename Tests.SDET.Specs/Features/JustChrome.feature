Feature: Just Chrome
	Ensures that only Chrome can access the JustChrome page

Scenario: JustChrome page is shown to Chrome users
	Given I am a normal user
	And I am using Chrome
	When I visit the JustChrome page
	Then I am shown the JustChrome page

Scenario: JustChrome page is not shown to non-Chrome users
	Given I am a normal user
	And I am using Internet Explorer
	When I visit the JustChrome page
	Then I am shown an error page
