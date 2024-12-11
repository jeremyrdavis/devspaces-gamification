## Challenge-04

### Scenario
* Lets continue to built on top of ds-challenge-03
* This section will explore on adding additional resources to the environment. There will be situations where a certain service testing needs more resources. In a traditional laptop, these type of resources may not be available either due to resource constraints or because the workload under test needs specific types of resources (example: GPUs). That forces the developers to either upgrade their laptops/desktops (which takes time) and or create a whole new setup on another machines. Let's see how we can avoid this pain point using DevSpaces

### Set Up + verification
* In devspaces, Open a terminal. Run the below command to change the mvnw file to be executable
* Refer to the Resources section and find out how to add memory and cpu requirements in devfile containers
* Add constructs for Resources to the "tools" container
    * Memory    : [Request : 512MB          and Limit : 2Giga Bytes]
    * CPU       : [Request : 500millicore   and Limit : 2000 millicore] 
* Add a "Post Start" event in the devfile to leverage the package command. 


### Success Criteria
* The devfile is updated with the memory and cpu requests and limits
* Reload the devspaces [Click the Arrows symbol(><) in the Bottom Left corner to open a new menu] with option "Restart Workspace from Local Devfile".
  > Due to the post start task, this process will take a while because the DevSpaces is downloading all the libraries. The UI is shown after the downloads are complete 
 
  ![ ](docs/images/challenge04.reload.jpg)

* After reloading when you run the task "2. Start Development mode", you will notice it is quicker

### Resources 
* https://devfile.io/docs/2.2.2
* https://devfile.io/docs/2.2.2/adding-event-bindings

### What did we learn?
* OpenShift DevSpaces reduces the Developers pain points. As a Developer, your life is getting simpler with the below
    * Automatic Extensions (Language Support for Java(TM) by Red Hat) inclusion
    * Automatic provisioning of required command line tools
    * Consistent way of building, packaging and running the programs making faster iterative development
    * Consistent way of creating standardized end points for current and future testing
* Now you can 
    * Request additional resources easily similar to any workload in the kubernetes
    * Add events to your IDE which can allow to do tasks : before start, after start or after stop of the workspace
