

### Exploring Developer Tools in the browser

As programmers, we sometimes wrongfully think the code is exclusive to us.

Take a look at the contents of some browser page you frequently visit. Open up developer tools. (Most browsers you can right click and pick inspect anywhere. Some browsers, it's F12, some browsers it's CTRL+SHIFT+I, etc...)

Make the following observations (don't think too much about "right" answers right now, this is just about exploring - these are intentionally vague exercises with no success criteria in order to spark some curiosity):
- What does the elements tab contain?
    - Have you seen any code that looks similar to this?
- What does the console tab contain?
    - Try inputting the following code in the console:
    ```js
    console.log(2 + 2);
    ```
    Think about this for a moment: How can your browser simply run this small program without any compilation or build steps? We're used to having phases from source code to machine code, but your browser seems to behave differently...
- What does the network tab contain? (try refreshing page after opening up the tab) (you might have used this in the week 35 project)
- What does the sources tab contain?
    - Why might this be interesting to know from a security standpoint?
- What does the application tab contain?
    - And try opening up the same web page in incognito/anonymous/private mode - is anything different?



### Browser Design mode

The browser application is always modifiable by the client.
Go to some web page, open up the developer tools and insert this Javascript snippet into the browser console:

```js
document.designMode = "on";
```

Now edit the webpage.
What happens in the "elements" section of a browser tab when you edit a page? (or vice versa)

### Other features you might find interesting before you start writing HTML:

Other actions that may be interesting to perform:
- Saving a webpage as an HTML document locally
- 


### Mozilla's Getting started guide:

**Task:** Go through Mozilla's HTML Getting Started guide:
https://developer.mozilla.org/en-US/docs/Learn/HTML/Introduction_to_HTML/Getting_started

### Exploring HTML elements and attributes

**Task:** Create a new empty directory and make a file ending in .html inside this directory. Open the file with your browser 

HTML tags use the following structure

```html
<elementname attributeName='attributeValue'>inner html content here</elementname>
```

Remember, HTML uses a tree structure, so many tags can be nested inside each other.

Make a basic static webpage using the following tags
(documentation for each tag can be found here: https://developer.mozilla.org/en-US/docs/Web/HTML/Element)

(The sub-sections are attributes which I recommend you put into the HTML element starting tag)

- div (container)
- p (paragraph)
- select (dropdown)
- option (dropdown item) (put option as Inner HTML to select element)
- a (hyperlink)
- br (line break)
- code (formats like code)
- b (bold text)
- i (italic text)
- img (image)
    - src (image source link)
- button (a clickable button)
    - onclick. Try like this:
    ```
    <button onclick="alert('You clicked the button!')">Click Me</button>
    ```
- input (an input field) Try setting the "type" attribute value as one of the following:
    - date
    - checkbox
    - file
    - password
    - range
    - radio
    - time
- h1 (a large heading)

**Success criteria:** You should now have a very simple (and probably not very pretty) user interface inside a browser

**Learning objective:** You must know basic HTML syntax, have a small arsenal of HTML elements you know, and be able to open an HTML document inside a browser
