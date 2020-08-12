Feature: Home page
	Ensure navigation options exist to social media

Scenario: Home page contains a link to Facebook
	Given I am a normal user
	When I visit the home page
	Then there is a link to facebook.com

Scenario: Home page contains a link to Twitter
	Given I am a normal user
	When I visit the home page
	Then there is a link to twitter.com

Scenario: Home page contains a link to YouTube
	Given I am a normal user
	When I visit the home page
	Then there is a link to youtube.com
