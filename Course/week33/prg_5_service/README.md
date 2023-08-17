### Presentation topics:
- Program.cs WebApplication & Builder
- Dependency Injection & service lifetimes
- Environments and environment variables

**Info**
- Check marketplace (where you install plugins) for Jetbrains AI Assistant
- If you have .NET 8 and want a controller layout without cloning my repo, you can run 

```c#
dotnet new webapi --use-controllers
```

Apparently, Rider with MVC creates a bunch of other stuff, so I recommend the above command.

**Recommended actions:**
- Doing exercises for today (prioritize yesterday's exercises if you haven't completed those)

### Relevant documentation & literature:
- Environments in .NET: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/environments?view=aspnetcore-8.0
- Article about dependency injection + service lifetimes: https://juldhais.net/all-about-dependency-injection-in-asp-net-core-15651a16f11f





## My guide to setting environment variables:


### Windows (without any particular terminal emulator)
<details  style="margin: 25px;">
  <summary>Click here to expand</summary>

1. Right-click the **Computer** icon on your desktop or in File Explorer.
2. Click **Properties**.
3. Click **Advanced system settings**.
4. Click **Environment Variables**.
5. Under **User variables** or **System variables**, click **New**.
6. For **Variable name**, enter your environment variable name.
7. For **Variable value**, enter the value of the environment variable.
8. Click **OK** to close all dialog boxes.
</details>



### Windows with Git Bash

<details  style="margin: 25px;">
  <summary>Click here to expand</summary>

1. Open a bash session and paste the following command and press enter:

```bash
echo 'export VARNEMT="value"' >> ~/.bash_profile
```
2. Now close down your terminal, open a new terminal, and to confirm the variable is present by writing the following command:

```bash
echo $VARNAME
```
And getting the value you set.

</details>


### macOS and Linux (using default terminal)

<details  style="margin: 25px;">
  <summary>Click here to expand</summary>

1. Open a terminal.
2. For temporary environment variables, enter `export VARNAME="value"`, replacing `VARNAME` with your environment variable name and `value` with the value of the environment variable. This will only set the variable for the duration of the current session.
3. For permanent environment variables, you need to edit either the `.bashrc` file (or `.zshrc` if using Z shell) in your home directory or the `/etc/environment` file and add `export VARNAME="value"` at the end of the file.

After setting the environment variables, you can access them in C# using `System.Environment.GetEnvironmentVariable("VARNAME")`, where "VARNAME" is the name of your environment variable.

</details>



---

**Remember:** For Windows users, the difference between **User variables** and **System variables** matters, as it changes the scope of the environment variable. User variables are specific to the user currently logged in, whereas system variables are accessible by all users.
