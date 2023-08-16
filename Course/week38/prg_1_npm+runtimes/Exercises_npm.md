### Exercise: Installing Node Version Manager

**Task:** Following installation instructions to install Node version manager here:
- Mac OS / Linux: https://github.com/nvm-sh/nvm
- Windows: https://github.com/coreybutler/nvm-windows/releases/tag/1.1.11 (Download nvm-setup.exe and run)

Then use 

```
nvm install 18
```


**Success criteria**: You should have Nodejs 18 installed afterwards when you run 

```
node -v
```

**Learning objective**: You must know how to set up an environment for Nodejs development in such a manner that allows for easy upgrading / changing versions in general

---

### Exercise: Initialize a Node Repository

**Task:** After installing Node.js, the next step is to initialize a new Node.js project. This is done using the Node Package Manager (`npm`), which comes bundled with Node.js. 

<details  style="margin: 25px;">
  <summary>Click here for guided solution</summary>

Open your terminal, navigate to the directory you want your new project to be in, then run the following command:

```shell
npm init
```

You will be asked a series of questions (such as the project's name, version, description, entry point, test command, git repository, keywords, author, and license). You can either provide answers or press `Enter` to accept the defaults. If you want to skip all questions and accept the defaults, you can use:

```shell
npm init -y
```
  </details>


**Success Criteria:** You should have a new file named `package.json` in your project directory. 

**Learning Objective:** You must understand how to initialize a new Node.js project using `npm init`. You should also understand the importance of the `package.json` file as it keeps track of all dependencies for your project and can contain scripts for running your application or tests. 

---


### Exercise: npm install

**Task:** After initializing a Node.js project, the next task is to install a package using npm (Node Package Manager).

<details style="margin: 25px;">
  <summary>Click here for guided solution</summary>

In your terminal, navigate to your project directory (where your `package.json` file resides), and run the following command:

```shell
npm install lodash
```

This command will download the lodash package (Javascript utility library) and add it as a dependency in your `package.json` file.

  </details>



**Success Criteria:** You should now have a new directory named `node_modules` in your project directory, where npm has installed packages. In addition, your `package.json` file will be updated with that package as a dependency. You can check this by opening `package.json` looking under dependencies.

```shell
cat package.json
```

**Learning Objective:** Learn how to use npm to install packages and add them as dependencies to your project. Understanding how to manage and utilize packages is an important part of Node.js development as it allows you to leverage existing libraries and modules, saving you from having to code everything from scratch.

---


### Exercise: Running a Hello World program inside Node.js

**Task:** Node.js allows you to write and run JavaScript directly on your machine, without the need for a browser. In this exercise, you'll create a simple "Hello, World!" program and run it using Node.js.

<details style="margin: 25px;">
  <summary>Click here for guided solution</summary>

Create a new file in your project directory named `app.js`. Open this file in a text editor and add the following line:

```javascript
console.log("Hello, World!");
```

Save and close the file. 

Then, in your terminal, navigate to your project directory and run:

```shell
node app.js
```
</details>

**Success Criteria:** "Hello, World!" should be printed to your terminal.

**Learning Objective:** Understand the basics of writing and running a JavaScript file using Node.js.


---

### Exercise: npm uninstall

**Task:** Remove a package (dependency) using npm uninstall


**Success Criteria:** After running the command, the package will no longer be listed under "dependencies" in your `package.json` file. Furthermore, the package will have been removed from the `node_modules` directory.

```shell
cat package.json
```

**Learning Objective:** Learn how to uninstall packages from your Node.js project with npm. Regularly removing unused dependencies can help keep your project maintainable and your deployments speedy.

---

### Exercise: Running a script from package.json

**Task:** Run some command as a script in package.json

<details style="margin: 25px;">
  <summary>Click here for guided solution</summary>


Open your `package.json` file in a text editor, and under "scripts", add the following line:

```json
"start": "echo Hello, World!"
```

Then, save and close `package.json`.

In your terminal, navigate to your project directory and run:

```shell
npm start
```
</details>

**Success Criteria:** You should get the expected outcome as if you performed the action without "npm run *script*"

**Learning Objective:** Understand how to use the "scripts" section of your `package.json` file to define and run tasks for your project.

---

### Exercise: Reading a File with Node.js

**Task:** Use 'fs' package to read from a text file with Hello World and print the contents to the console.

**Help:** https://www.w3schools.com/nodejs/nodejs_filesystem.asp

<details style="margin: 25px;">
  <summary>Click here for guided solution</summary>

One of the features that sets Node.js apart from browser-based JavaScript is the ability to interact directly with the file system. In this exercise, you'll use the built-in `fs` module to read a file.

Create a new file in your project directory named `hello.txt`. Open this file in a text editor and add the text "Hello, Node.js!".

Create another new file in your project directory named `readfile.js`. Add the following code to this file:

```javascript
const fs = require('fs');

fs.readFile('hello.txt', 'utf8', (err, data) => {
  if (err) {
    console.error(err);
    return;
  }
  console.log(data);
});
```

Then, in your terminal, navigate to your project directory and run:

```shell
node readfile.js
```
</details>

**Success Criteria:** The file contents should be printed to the console.

**Learning Objective:** Seeing how Javascript in a runtime can use system-native functionalities (like file-reading), which Javascript in browsers cannot do.

---

### Exercise: Creating a Basic HTTP Server with Node.js

**Task:** Make "server-side functionality" with Javascript by using Nodejs library 'http' to run an HTTP server with a hello world endpoint. 

**Help:** https://www.w3schools.com/nodejs/nodejs_http.asp

<details style="margin: 25px;">
  <summary>Click here for guided solution</summary>
Create a new file in your project directory named `server.js`. Open this file in a text editor and add the following code:

```javascript
const http = require('http');

const server = http.createServer((req, res) => {
  res.statusCode = 200;
  res.setHeader('Content-Type', 'text/plain');
  res.end('Hello, World!\n');
});

server.listen(3000, 'localhost', () => {
  console.log('Server running at http://localhost:3000/');
});
```

Save and close the file. Then, in your terminal, navigate to your project directory and run:

```shell
node server.js
```
  </details>



**Success Criteria:** You should be able to get a response from the running HTTP server when requesting an endpoint.

**Learning Objective:** Seeing how network-based appl