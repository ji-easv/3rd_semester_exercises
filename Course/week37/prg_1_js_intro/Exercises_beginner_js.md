### Mozilla's "First Steps"
**Task:** I recommend reading Mozilla's First Steps until the "Arrays" portion(see in sidebar):
https://developer.mozilla.org/en-US/docs/Learn/JavaScript/First_steps


### The console and basic javascript objects

**Task:** Explore the browser console API. I recommend trying out the following methods which I find to be very helpful to know:
```js
console.log();
console.table();
console.error();
console.group();
console.dir();
```
Mozilla Docs for console: https://developer.mozilla.org/en-US/docs/Web/API/console

**Success criteria:** You should feel comfortable with logging to the browser console using the browsers native console API with Javascript.

**Learning objective**: You will constantly be logging things in development mode, so you might as well know a couple different methods.


### DOM manipulation

**Task:** Use the "Document" interface to manipulate the browser DOM using Javascript. You can use your HTML document from last week as a basis.

*(This is the "manual" version of what the library jQuery essentially has "prettier" methods to do. When we build SPA's after this JS intro, you will never have to use either approach, since Angular has built-in DOM manipulation methods which are far superior)*

My recommended starting selection of methods:

```js
//Accessing elements:
document.getElementById();
document.getElementBysByClassName();

//To create a new HTML element and insert it somewhere, combine these:
document.createElement()
document.appendChild()

//You can use the following element properties to modify attributes and Inner HTML(this is outside of the Document interface, but are commonly used in conjunction)
element.innerHTML 
element.onclick 
element.scrollIntoView()
element.setAttribute()

```

Mozilla Docs for "Document" interface for manipulating the Document Object Model using Javascript: https://developer.mozilla.org/en-US/docs/Web/API/Document


### Storing data client side

**Task:** Storage some value by key name in the browser using localStorage: https://developer.mozilla.org/en-US/docs/Web/API/Window/localStorage

**Success criteria:** When you open up the "application" tab in your browser developer tools, and navigate to the current webpage, you should be able to see the value.

**Learning objective:** You must be able to store a value client side, which is frequently done in order to access data like the client's security token.

### Retrieving localStorage data

**Task:** Now that you have stored some value using localStorage.setItem(keyname, value), try retrieving a value by keyname or clearing the localStorage.

**Success criteria:** Check that the value is not undefined when you access it in the program. Also check that you can clear it using the method localStorage.clear();

### String methods

**Task:** Use the built-in string methods to do the following actions: (no loops are needed)

- Turn a string into lowercase
- Remove whitespace at the beginning or end of a string
- Remove everything of a string except characters from 2-4
- Get index number 3 of a string
- Return true if a string contains the character A


String docs: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/String

**Success criteria**: If you're unsure whether or not your methods do what they're supposed to, try writing unit tests. *(You don't need a particular library, just console.log(true) if the method outputs as expected for several different inputs)*

**Learning objective:** Using string methods is a fundamental building block of Javascript programming, and is relevant to learn no matter what framework(s), libraries or browser(s) you will be using.


### Array methods

Array docs: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array


**Task:** Use JS built-in array methods:

Use Array.map() to do the following actions:

- Multiply every number by 2 in an array
- Trim every string in an array
- Add a property to every object in an array of objects

Use Array.filter() to do the following actions:
- Remove all numbers greater than 42
- Remove all strings starting with e and shorter than 5

Use the Array docs to find the methods required to do the following actions:
- Add an element to the end of an array
- Add an element to the beginning of an array
- Remove an element from the end of an array
- Remove an element from the beginning of an array
- Find the length of an array

**Success criteria**: If you're unsure whether or not your methods do what they're supposed to, try writing unit tests. *(You don't need a particular library, just console.log(true) if the method outputs as expected for several different inputs)*

**Learning objective:** Using array methods is a fundamental building block of Javascript programming, and is relevant to learn no matter what framework(s), libraries or browser(s) you will be using.