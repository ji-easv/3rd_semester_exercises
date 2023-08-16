### New Solution (.sln file) with projects

**Task:** Make a new empty solution, which can contain a number of projects.

**Success criteria:** It should be possible to open the solution and enable "solution overview" rather than file overview in IDE's such as Rider and Visual Studio.

**Learning objective:** You must be able to create solutions, which are "containers" for projects.

---

### Add reference

**Task:** At least 1 project (such as a console application) inside the solution much reference another project (class library). 

**Success criteria:** If you successfully can call a function inside another project, the reference has successfully been added.

**Learning objective:** You must know how to structure an application.


---

### Add a nuget package

**Task:** 
Use either the CLI or GUI inside of your IDE / Editor to add a nuget package to you Class Library C# Project. 

**Success Criteria:** You should be able to make use of the nuget package (like calling a method).

**Learning Objective:** You must know how to use the nuget package manager to install libraries into your application.


---

### Remove dependency

**Task:** Remove a dependency such as a project reference or package reference from a project.

**Success criteria:** You application should no longer be able to call methods from inside given referred dependency.

**Learning objective:** You must know how to remove dependencies you have previously installed.

### Remove project from solution

**Task:** The solution should no longer have any awareness of a given project.

**Success criteria:** When using solution overview, the project should not be visible

**Learning objective**: You must know how to re-structure your solution overview


### Delete project entirely

**Task:** Now delete the C# project (different from the previous exercise, where we just removed the solution reference)

**Success criteria:** The .csproj file should no longer be present.

**Learning objective**: You must see the difference between removing reference between two projects, removing a project from a solution and deleting the project.