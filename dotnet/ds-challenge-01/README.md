## Challenge-01

### Scenario
* This simulates the scenario of a developer who is given a task of enhancing an existing service that was created by another developer
* The challenge (pain) of understanding required extensions is borne by the developer that is assigned this enhancement task

### Set Up + verification
* Open a terminal. Run the below command to clean the solution so you're running a fresh compile
    ```bash
    dotnet clean
    ```
* Run the below command to check for compilation errors. You will see the code compiles fine
    ```bash
    ./dotnet build
    ```
* Run the dotnet application in live coding mode
    ```bash
    ./dotnet run
    ```
* On the prompt press [r] to resume testing. This will result in an error
* Open the "Program.cs" file. You will observe the method "getCurrentDate" needs to be fixed.
* When you select all the code, right click and choose "Refactor"", the code does not format

### Success Criteria
* Fix the formatting by Installing Required extensions. Code is formatted with the extensions
* Restart your workspace (if required) for setting to be reflected
* Method getCurrentDate code is completed. The code should show java intellisense in action
* The live coding mode shows no errors and should indicate "All 1 test is passing"

### Resources
* Look for hidden clue(s) in source files that can help finishing the task sooner!

### What did we learn?
* Developer have challenging tasks : Example -- finding out which extensions are needed
* Unless there is a documentation and or guidance (like this scenario sections), it will be trial-and-error
* No guidance also results in lost time, productivity and delays the joy of coding
