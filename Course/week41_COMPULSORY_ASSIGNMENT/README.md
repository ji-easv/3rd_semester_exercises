### COMPULSORY ASSIGNMENT

# The box factory

*The boomer boss of the box factory wants to modernize by having an in-house application to keep track of their products (boxes).*

He wants employees to be able to add new boxes to their catalogue, edit existing, remove and find particular boxes based on searching and sorting preferences. *(Don't worry about user authentication - security concerns are generally ignored for this assignment, so it's alright that any user can perform CRUD)*

Boxes vary by different properties *(size, material, etc)*.
He also wants to be able to keep track of orders *(customer X orders some units of boxes)*, so he can see how the business is faring while he is playing golf.

Strict requirements:
- There must be a front(Angular) and back(.NET) -end applications.
- There must be communication via HTTP.
- There must be server side data validation.
- There must be data persistence using some variant of an object-relational-mapper (preferably Dapper)
- There must be at least 2 different business entities and some relational data. *(**cardinality**, like one-to-many between two entities)*
- You must submit by sending me a link to your version control remote repository (You don't have to deploy anything)
- Any testing deemed relevant in the group must be conducted in order to assure quality. 
- Development practices such as building and testing must be automated using Github Actions.
- Submission deadline is October 29th at 23:59:59. Submission is done on Moodle. (Submission is by the end of week 43. Week 42 is holiday, so make sure to discuss with your group whether or not you plan on finishing the assignment before or after week 42)

Other info:
- The assignment can be done individually or in groups.
- You don't have to write a report. If you have anything to say, please just make a README.md file and put it in the root folder. I always read the README.
- The requirements are intentionally vague and subject to interpretation (except for the strict requirements). You must determine what your level of ambition is for yourselves and work accordingly. Furthermore, I also want you to be a little creative with your solutions.