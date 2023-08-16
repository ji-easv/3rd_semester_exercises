### Bogus & Making your own integration tests for Dapper

**Task: Preparing for Integration testing:** Install Bogus using Nuget package manager, and use this library to creating pseudo-random data. Get started by making objects from your Entity classes.

**Task: Integration testing:** Now use Bogus to create integration tests for Dapper queries. This can be done using NUnit and Fluent Assertions. 

Here's some inspiration for queries which you can attempt to write and test:

- Add author to a book's authors
- Count number of books some author wrote
- Select all books on reading list for user with ID X
- Get top 5 books by most "added to reading list"
- Get user with most books on their reading list

I recommend following this procedure with the 3xA pattern for writing the tests:

- Arrange
    - Is there any data which must be present in the database for the test to complete?
        - Make new objects with Bogus and insert these with Dapper first
    - Do you need to prepare an expected value?
- Act
    - Calling the method which you are testing
- Assert
    - Using Fluent Assertions to formulate some sort of "expectation" based on the "Act"-ual outcome
    - Are there more assertions which must be true? Then make an assertion scope

**Success criteria:** When you write your new infrastructure methods, you should feel confident that your methods consistently perform as expected.

**Learning objective:** You should now be able to write and test infrastructure methods using relevant technologies to an extend where you can use this in a real-life distributed system.