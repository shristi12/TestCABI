# Introduction 
This is a simple practical test for an SDET role at CABI.

# Getting Started
The entire interview process is as follows
1.	Telephone interview (one-to-one)
2.	Practical test (a series of tasks for the candidate to perform to check skills and understand)
3.	Face-to-face interview (conducted with future line manager and one or two other managers)

# Practical test
The practical test is a .NET Core 3.1 soliution features a simple webapp, xUnit Tests project (for traditional unit tests) and an xUnit Specs for project for BDD-style tests using SpecFlow.
Each of the tasks below should be completed to the best of your ability.  The test will then be reviewed and then discussed as part of your face-to-face interview.
Note: This test is not necessarily an example of best practice in all cases, sometimes deliberately so, but rather is for the purposes of testing your knowledge and understanding and providing suitable discussions points in a face-to-face interview.

# Tasks
Each task should be doable independently of the other tasks unless otherwise stated.

1.  Refactor the HomePage feature scenario so the three social media scenarios are condensed into one (this includes the scenarios are steps)
2.  Implement the tests required to test the scenarios described in JustChrome.feature using Selenium or similar
3.  Review the following user stories and indicate if they pass or fail.  If they fail, indicate why.  Also note if you think the story is written well or not, regardless of whether it passes testing.

## Story 1
As a marketing executive
I want social media links on the home page
So that users can easily find and follow us on popular social media platforms
A/C
Are links for Facebook, Twitter and YouTube available on the home page?

## Story 2
As a security expert
I want a page to display a warning when ran on outdated browsers
So that potentially insecure browsers aren't used to access the site and modern web technologies can be used
A/C
If a user accesses the browser test page on Internet Explorer, are they shown a suitable warning?
If a user accesses the browser test page on Chrome, are they shown the test page without error?

## Story 3
As an end user
I want the privacy page to have a way to change the displayed name
So that I don't have to change the name myself
A/C
Is a JavaScript method implemented to change Bob to Fred?
