# Introduction
Thanks you for your interest in CABI and the role of SDET (Software Development Engineer in Test).  The role is based in our Delhi, India office and will involve working with a team of 15-person team to support our QA activities.
This will include:
- Manual testing of web, API and mobile app testing
- Creating and maintaining automated regression tests using Selenium (Java)
- Working with our software engineers to write and help them write better unit and integration tests (C# - .NET Framework, .NET Core 3.1 and .NET 5)
- Working in our agile teams to review stories
- Support the team in a move towards BDD

# Required Skills and Experience
- C# (.NET Framework, .NET Core 3.1 and .NET 5)
- xUnit, NUnit or MS Test Testing Framework (xUnit preferred)
- Selenium (Java-based ideally)
- Agile (ideally scrum) Methodology

# General Overview
The interview process we will be following is as follows:
1.	Telephone interview (one-to-one)
2.	Practical test (a collection of tasks for the candidate to perform to check skills and understanding)
3.	Face-to-face interview (conducted with future line manager and one or two other managers) via Zoom

# Pre-Test & Interview Requirements
Ahead of the practical test and face-to-face interview, please ensure you have access to the following:
- Zoom installed on your computer - https://zoom.us/download#client_4meeting (you don't need an account)
- Visual Studio installed on your computer (ideally 2019, any edition will do including Community Edition)
- .NET Core 3.1 installed and usable in a project in Visual Studio
- SpecFlow extension installed
- Chrome and another browser
- A GitHub account set up and shared with CABI at least 4 hours before the test is scheduled to start

# Practical test
- The practical test is a .NET Core 3.1 solution and features a simple webapp, xUnit Tests project (for traditional unit tests) and an xUnit Specs project for BDD-style tests using SpecFlow.
- Each of the tasks below should be completed to the best of your ability.  The test will then be reviewed and then discussed as part of your face-to-face interview.
- Note: This test is not necessarily an example of best practice in all cases, sometimes deliberately so, but rather is for the purposes of testing your knowledge and understanding and providing suitable discussions points in a face-to-face interview.

## How to complete the test
- Log in to GitHub and take a clone of the repo https://github.com/cabi-org/Test.SDET.2020
- If you are unable to clone the repo, use the "Download Zip" option
- Complete the tasks below, committing your answers locally as you see fit
- For questions, update the README.md file to include answers at the appropriate point in the file
- Access will be granted to the repo for your GitHub account at the start of the test window and removed at the end of your alloted time
- We will try to give you a 1 minute warning via Zoom however you are responsible for knowing when your time is up
- You will have **60 minutes** to complete the test from receiving access to the repo
- If you finish the test early, let us know
- You are permitted to use the Internet during this test as long as you are looking up information and not asking other people for answers
- Please be aware, you will need to share your screen during the face-to-face interview to discuss your test

# Tasks and Questions
Each task should be doable independently of the other tasks.

1.  Refactor the HomePage feature scenario so the three social media scenarios are condensed into one (this includes both the scenarios and their associated steps)
2.  Implement the tests required to test the scenarios described in JustChrome.feature using Selenium or similar (if you don't have Internet Explorer on your machine, substitute another browser)
3.  Review user stories 1, 2 and 3 below and indicate if they should pass or fail a manual QA process.  If they fail, indicate why.  Also note if you think the story is written well or not, regardless of whether it passes testing.
4.  Using TDD, implement user story 4 below.  Add the code to the existing OurProcessor.cs class and add the tests, inside a region called TDD, to the OurProcessorShould.cs class in Tests.SDET.Tests.  To show your approach, commit each stage and add a comment of Q4a, Q4b, Q4c, etc... for each iteration. 

## Story 1
As a marketing executive  
I want social media links on the home page  
So that users can easily find and follow us on popular social media platforms  
A/C  
Are links for Facebook, Twitter and YouTube available on the home page?  

Pass or fail: Pass/Fail  
Story written well: Yes/No  
Additional comments (if any):

## Story 2
As a security expert  
I want a page to display a warning when ran on outdated browsers  
So that potentially insecure browsers aren't used to access the site and modern web technologies can be used  
A/C  
If a user accesses the browser test page on Internet Explorer, are they shown a suitable warning?  
If a user accesses the browser test page on Chrome, are they shown the test page without error?  

Pass or fail: Pass/Fail  
Story written well: Yes/No  
Additional comments (if any):

## Story 3
As an end user  
I want the privacy page to have a way to change the displayed name  
So that I don't have to change the name myself  
A/C  
Is a JavaScript method implemented to change Bob to Fred?  

Pass or fail: Pass/Fail  
Story written well: Yes/No  
Additional comments (if any):

## Story 4
As a developer  
I want a new method adding to OurProcessor that can add two positive numbers together  
So that I don't have to check numbers are positive each time I add them  
A/C  
Does adding 3 and 5 result in the answer 8?  
Does adding 8 and 6 result in the answer 14?  
Does trying to add zero or a negative number result in an error being thrown?
