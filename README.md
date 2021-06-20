# Open Air Quality Api

## Brief

The Open AQ air quality API is a simple example of a free web-based API that we can pass data to and retrieve results from. 
The main function of the API, and the purpose of it for this test, is to provide the current air quality for a city.

Documentation on the API can be found here:
https://docs.openaq.org/ 

## Goal

The goal of this exercise is to build a web client that interacts with this API. 
It should be able to send different parameters to the API, and display the air quality results for a given city in a friendly manner.

The solution should also implement:

- Clean structured code
- Well documented
- Dependency Injection
- Examples of design patterns

## Approach

Built using .NET Core, the solution follows Clean Architecture and implements the Mediatr CQRS pattern. Adopting this approach also allowed for simple Logging and Validation to be used.

There are four layers to the solution:

- Presentation Layer
- Application Layer
- Domain Layer
- Infrastructure Layer

The solution also followed TDD principles and the tests can be found in the api-air-quality.Web.Tests solution. Tests were written with NUnit.

## Screenshots

### Homepage
![image](https://user-images.githubusercontent.com/49981579/122680741-a709fe80-d1e8-11eb-8274-b65b403e0766.png)

### Air Quality for City Page
![image](https://user-images.githubusercontent.com/49981579/122680746-ae310c80-d1e8-11eb-8cbb-1f8a6e5638e0.png)


