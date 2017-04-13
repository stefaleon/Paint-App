# Paint Application
[Programming for Beginners in C# Windows Forms](https://www.udemy.com/programming-windows-applications-for-desktop-in-c-sharp/)

&nbsp;
## 00 Start the project
* In VS, create a Windows Forms Application project.

&nbsp;
## 01 Form Initial Setup
* Set background and initial size: In the *Properties* tab, set *BackColor* to white and *Size* to 800, 600.
* From the *Toolbox*, add a *StatusStrip*.

&nbsp;
## 02 Initialize variables
* Add the *listOfPoints* and *pencilDown* variables and initialize them.
```
        ArrayList listOfPoints;
        bool pencilDown;

        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            pencilDown = false;
        }
```
