### Exercise: Middleware: Log to console for every request
**Task:** Write the "hello world" of middleware: For every request, use Console.WriteLine(string value); to print some value to the console.

**Success criteria:** You should be able to see the expected value in the console.

**Learning objective:** You should be able to see that you middleware successfully is triggered.

### Exercise: Middleware: Global exception handler

**Task:** Make middleware which can catch all uncaught exceptions for every HTTP request. (without using [ApiController] attribute).
Make sure you return some custom value to the client based on the exceptions.

**Success criteria:** Throw an exception like this:
```c#
throw new Exception("TEST MESSAGE");
```
Does the client see this value?

### Exercise: Action Filter: Validate DTO model based on data annotations
**Task:** Make an action filter which can evaluate if a DTO is valid based on Data Annotations for its class.

**Success criteria**: Make a request which you expect to be invalid based on Data Annotations. Does the server respond with a 400?

**Learning objective:** You must be able to perform server side data validation using data Annotations, however, you should "manually" trigger the Model validation instead of using [ApiController]

### Exercise: Middleware: Route not found middleware
**Task:** If a client requests some route that does not exist, respond with "Route not found"

**Success criteria:** Send a request which you expect to trigger this middleware. Do you see the value? Also check that your valid routes still work.

**Learning objective:** You must know how to setup middleware with "custom" triggers, such as when a certain route is requested (such as a non defined route).