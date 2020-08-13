# Introduction 
This is a simple practical test for an SDET role at CABI.

# Getting Started
The entire interview process is as follows
1.	Telephone interview (one-to-one)
2.	Practical test (a series of tasks for the candidate to perform to check skills and understand)
3.	Face-to-face interview (conducted with future line manager and one or two other managers) via Zoom - please ensure this is installed ahead of the interview process

# Practical test
- The practical test is a .NET Core 3.1 soliution features a simple webapp, xUnit Tests project (for traditional unit tests) and an xUnit Specs for project for BDD-style tests using SpecFlow.
- Each of the tasks below should be completed to the best of your ability.  The test will then be reviewed and then discussed as part of your face-to-face interview.
- Note: This test is not necessarily an example of best practice in all cases, sometimes deliberately so, but rather is for the purposes of testing your knowledge and understanding and providing suitable discussions points in a face-to-face interview.

## How to complete the test
- Log into GitHub and take a clone of the repo
- Create a new branch from master called your name (e.g. if your name as shown on your CV is Joan B. Smith, call the branch joan-b-smith)
- Complete the tasks below, committing your answers locally as you see fit to your branch
- For questions, update the README.md file to include answers at the appropriate point in the file
- Once you've completed the test or your time is about to elapse, push your changes to origin.
- Access will be granted to the repo for your user at the start of the test window and removed at the end of your alloted time

# Tasks and Questions
Each task should be doable independently of the other tasks unless otherwise stated.

1.  Refactor the HomePage feature scenario so the three social media scenarios are condensed into one (this includes the scenarios are steps)
2.  Implement the tests required to test the scenarios described in JustChrome.feature using Selenium or similar
3.  Review user stories 1, 2 and 3 below and indicate if they should pass or fail a manual QA process.  If they fail, indicate why.  Also note if you think the story is written well or not, regardless of whether it passes testing.
4.  Using TDD, implement user story 4 below.  Add the code to the existing OurProcessor.cs class and add the tests to the OurProcessorShould.cs class in Tests.SDET.Tests.  To show your approach, commit each stage and add a comment of Q3a, Q3b, Q3c, etc... for each iteration

## Story 1
As a marketing executive  
I want social media links on the home page  
So that users can easily find and follow us on popular social media platforms  
A/C  
Are links for Facebook, Twitter and YouTube available on the home page?  

Pass or fail: Yes/No  
Additional Comments (if any):

## Story 2
As a security expert  
I want a page to display a warning when ran on outdated browsers  
So that potentially insecure browsers aren't used to access the site and modern web technologies can be used  
A/C  
If a user accesses the browser test page on Internet Explorer, are they shown a suitable warning?  
If a user accesses the browser test page on Chrome, are they shown the test page without error?  

Pass or fail: Yes/No  
Additional Comments (if any):

## Story 3
As an end user  
I want the privacy page to have a way to change the displayed name  
So that I don't have to change the name myself  
A/C  
Is a JavaScript method implemented to change Bob to Fred?  

Pass or fail: Yes/No  
Additional Comments (if any):

## Story 4
As a developer  
I want a new method adding to OurProcessor that can add two positive numbers together  
So that I don't have to check numbers are positive each time I add them  
A/C  
Does adding 3 and 5 result in the answer 8?  
Does adding 8 and 6 result in the answer 14?  
Does trying to add zero or a negative number result in an error being thrown?
