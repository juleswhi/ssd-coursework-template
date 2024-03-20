# Software Systems Coursework Template

This template uses Windows Forms for the application, and Asciidoc for the Writeup

To learn more about Windows forms, look [here](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-8.0).

To learn more about Asciidoc, look [here](https://asciidoc.org/). It's recommended that you spend 30-60 minutes looking at the documentation before writing your coursework.

If Asciidoc looks too daunting, you can always use Google Docs instead.

## Installation

To install the template, you can clone this repository with a tool like [Github Desktop](https://desktop.github.com/).

Alternatively, you can download the whole project as a zip and then unzip it onto your computer. `Code -> Download ZIP`

## Setup

To get working on your coursework, open `Visual Studio`. You should already have experience with using it, but [here](https://visualstudio.microsoft.com/vs/getting-started/) is a quick guide if you need reminding.

Navigate to the `/src` ( Source ) directory and double click on the Solution File, `AS_SSD_Coursework.sln` to open with `Visual Studio`.

Press `Ctrl-Shift-B` to build the project and ensure there are no build errors.

## Initial Configuration

First, delete the starting classes in the, `Views`, `Models` and `Controller` directories. E.g, `Form1.cs`.

Create your first form and place it in the `Views` directory. A good starting place would be a login form.

Remember to adhere to Windows Forms naming conventions, forms should be called `formName`.

Navigate to `Program.cs` and find the following line:

```cs
// Start<form1>();
```
Uncomment this line and replace `form1` with the name of your form. 

Next, go to the namespace in `Program.cs` and change it to your application name.

If you want to, you can change the solution name aswell, and even the default namespace name.

## Finally..

Delete this README file, and rename `ExampleReadme.md` to README.md. 

Make sure to update the README to reflect your project name etc.