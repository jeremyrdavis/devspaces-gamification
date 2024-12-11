## Challenge-02

### Scenario
* Similar scenario like challenge-01 (You are given a requirement to enhance a service)
* However, you will start seeing benefits of DevSpaces (Extensions + Tooling)

### Set Up + verification
* After DevSpaces initialization, check the extensions. You will see under "DevSpaces.apps.cluster" the extension ".NET Install Tool" is already installed. This is done via the ".vscode/extensions.json" file
* Tools that are required for development are already present : Type "oc --help", "jq --help" etc... This is possible because of the ds-challenge-02/devfile.yaml "tools" container (line#07). Using this tools container allows for standardization across the developers (everyone will have the same set of tools when logged in)
    ```bash
    oc --help
    ```
    ```bash
    jq --help
    ```
* With tools and the extensions already part of the source code, your job becomes much easier to just start coding
* Run the below command to check for compilation errors. You will see the code compiles fine
    ```bash
    ./dotnet build
    ```
* Run the quarkus application in live coding mode
    ```bash
    ./dotnet run
    ```
 
* Open another terminal and invoke "curl localhost:8080/api/greet/bengaluru". You will see empty result
* Open the "Program.cs". You will observe the method "greetUser" needs to be fixed.

### Success Criteria
* Method "greetUser" is updated to accept a string as a parameter and returns a concatenated string of "Hello " and the passed name
* Invoking below service endpoint and it should return "Hello bengaluru"
    ```bash
    curl localhost:8080/api/greet/bengaluru
    ```

### Resources
* https://dotnet.microsoft.com/en-us/learn/csharp
* https://learn.microsoft.com/en-us/shows/c-fundamentals-for-absolute-beginners/
* https://registry.devfile.io/viewer/devfiles/community/udi

### What did we learn?
* Developers life is getting easier with required extensions already integrated via the DevSpaces. This takes the guess work out
* Extensions settings are created under ".vscode/extensions.json" file
* Developers do not have to worry about command line tools
* Taking one step forward to creating the developer joy. In this excercise, the developer still has to figure out how to compile, package etc.. Let's see how to address those in the next challenges