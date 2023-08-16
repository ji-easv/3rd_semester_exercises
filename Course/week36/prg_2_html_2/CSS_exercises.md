### Mozilla's Getting started

**Task:** Follow Mozilla's Getting Started guide: https://developer.mozilla.org/en-US/docs/Learn/CSS/First_steps
Until and including "How CSS is structured" (see in the sidebar).

### Selectors & Properties

**Task:** Use your HTML projects from last time. Experiment by adding CSS, either by making CSS classes or adding HTML style tags (or both).

Select elements using the following approaches:
- Selecting by element name
- Selecting by element ID
- Selecting by class

I recommend getting started with a small arsenal of CSS properties. Here are my suggestions:

#### Text Styling
- `color`: Sets the text color.
- `font-family`: Sets the font used for text.
- `font-size`: Sets the size of the text.
- `text-align`: Aligns text (e.g., left, right, center, justify).

#### Spacing and Layout
- `margin`: Sets the space outside an element's border.
- `padding`: Sets the space inside an element's border.
- `width`: Sets the width of an element.
- `height`: Sets the height of an element.

#### Borders
- `border`: Sets the border around an element.
- `border-radius`: Rounds the corners of an element's border.

#### Backgrounds
- `background-color`: Sets the background color of an element.
- `background-image`: Sets a background image for an element.

#### Positioning
- `position`: Controls the positioning method (e.g., static, relative, absolute).
- `top`, `right`, `bottom`, `left`: Positions an element when used with relative or absolute positioning.


### Add lightweight CSS framework

Here are my favorites libraries which all modify basic HTML elements without you needing to learn anything new or do anything differently *(phew)*. 

Just paste one of the link elements into the top of your HTML (preferably in the <*head*> section):

```html
<!-- Use one of the following, not all at the same time: -->

<!-- Milligram -->
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/milligram/1.4.1/milligram.css">

<!-- Sakura-->
<link rel="stylesheet" href="https://unpkg.com/sakura.css/css/sakura.css" type="text/css">

<!-- Wing -->
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/wingcss/0.1.8/wing.min.css">

```
**Task:** Explore these lightweight CSS frameworks, and enjoy your webpage which doesn't look like something from the 90's anymore


### Further reading

Are you considering a more UI-focused profile as a developer? My recommendation for a more heavy CSS framework to learn which will drastically boost your CSS productivity is Tailwind. If you want the power of a "traditional" framework with prebuilt and configurable components, I recommend Daisy UI, which builds on top of Tailwind CSS.

*(The preliminary knowledge I recommend before starting Tailwind CSS is: The box model, grid layout, flexbox, media queries, and more general "basic" CSS practice first)*