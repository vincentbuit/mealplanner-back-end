# Meal Planner (back end)

Manage your own recipes, plan your meals for the week and automatically create a groceries list. This is an over-engineered application for learning new technologies and concepts that will make me a better developer overall. See also the front end repo: https://github.com/vincentbuit/mealplanner-front-end.

## Technologies and concepts to master in the back end

### Technologies

- .NET Core (framework)
  - MVCS (design pattern)
  - Entity framework (object-relational mapping framework)
  - Bogus (fake-data)
  - C# (language)
    - Configuring compiler
- SQLite3 database
- REST API with OpenAPI3 and swagger
- Git (version control)
    - Small and atomic commits
    - Branches which are easy to review and follow an easy to understand narrative
    - Splitting, combining commits and everything else related to interactive rebase    
    - Using git history to your advantage by searching through previous commit messages and code changes using ```git log``` and ```git blame```

### Concepts

- Standards: Don’t allow bad designs, wrong decisions or poor code. (The Pragmatic Programmer p6)
- Documentation: Restrict non-API commenting to discussing why something is done, its purpose and its goal. (The Pragmatic Programmer p23)
- Easy To Change (ETC): Isolate concerns, single responsibility, good naming and write replaceable code. (The Pragmatic Programmer p28)
- Don’t Repeat Yourself (DRY): No duplication in code, documentation, data and APIs. (The Pragmatic Programmer p30)
- Reusibility: Make code easy to reuse. (The Pragmatic Programmer p37)
- Orthogonality: Eliminate effects between unrelated things. (The Pragmatic Programmer p39)
- Flexibility: There are no final decisions, remain as flexible as you can. (The Pragmatic Programmer p48)
- Tracer bullets: Quickly, visibly and repeatably get from requirements to some aspect of the final system. (The Pragmatic Programmer p50)
- Estimate: Iterate the schedule with the code to better communicate when projects are finished. (The Pragmatic Programmer p65)
- Engineering daybook: Learn from choices, bugs for the future by writing it down. (The Pragmatic Programmer p100)
- Design by Contract (DBC): Think about preconditions, postconditions and repercussions. (The Pragmatic Programmer p104)
- Memory leaks: Prevent them by acting locally. (The Pragmatic Programmer p121)
- Parameterization: Using external configuration to control your app. (The Pragmatic Programmer p166)
- Refactoring: Doing it early and doing it often. (The Pragmatic Programmer p209)
- Test driven development. (The Pragmatic Programmer p214)
- Naming: Name well and rename when needed. (The Pragmatic Programmer p238)

## Plan

### Stage 1: Setup project

- ~~Design a plan including recourses~~
- Setup .NET core project with Model, Controller and Service structure and configuration
    - https://tom-collings.medium.com/controller-service-repository-16e29a4684e5
    - https://softwareengineering.stackexchange.com/questions/230307/mvc-what-is-the-difference-between-a-model-and-a-service
    - https://learn.microsoft.com/en-us/dotnet/core/extensions/configuration
    - https://medium.com/gettech-blog/is-this-real-strict-mode-in-c-compiler-5e23f1eec5fa
- ~~Setup SQLite3 database~~
- ~~Setup Entity framework and make it work with SQLite3 database~~
    - https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
- ~~Setup OpenAPI3 with swagger and get REST API up and running
    - https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-6.0
- Setup Bogus for fake data
    - https://github.com/bchavez/Bogus
- Setup dotnet format using git hooks
    - https://gsferreira.com/archive/2022/embedding-dotnet-format-in-your-development-cycle/
    - https://randulakoralage82.medium.com/format-your-net-code-with-git-hooks-a0dc33f68048

### Step 2: Design

- Define database schematics
  - Include DTOs with library like AutoMapper
    - https://learn.microsoft.com/en-us/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-5
- Sketch a BE design which incorperates the concepts defined earlier
    - https://blog.devgenius.io/top-common-memory-leaks-using-c-ba80331b62d4
    - https://softwareengineering.stackexchange.com/questions/128717/why-is-there-such-limited-support-for-design-by-contract-in-most-modern-programm
- Create branches roadmap to improve orthogonality
- Write tests
    - https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices
    - https://medium.com/geekculture/test-driven-development-for-net-core-1630f8707324

### Step 3: Write back end

- Define steps to writing back end
    - https://dev.to/azure/modern-javascript-10-things-you-should-be-using-starting-today-1adm
    - https://dev.to/htissink/8-new-things-in-modern-c-1a2b
    - https://www.pluralsight.com/guides/tips-for-writing-better-c-code
    - https://blog.ndepend.com/modern-c-hello-world/
    - https://learn.microsoft.com/en-us/dotnet/csharp/nullable-references
    - https://stackoverflow.com/questions/163538/c-sharp-what-does-the-assert-method-do-is-it-still-useful
    - https://learn.microsoft.com/en-us/dotnet/api/microsoft.visualstudio.testtools.unittesting.assert?view=visualstudiosdk-2022
