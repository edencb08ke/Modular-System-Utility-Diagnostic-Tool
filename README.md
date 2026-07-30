When I updated the source code attached to this repos, it wiped the previous README.md; I will try to recreate it but the changelog will not match commit history.
Essentially, this is a WinForms project written in C# on Visual Studios, to try to give easy access to some PC maintenance, without having to mess around in Powershell or cmd
Originally I tried to do this on .NET 4.7.2 but needed to update to .NET 8.0 on a new project without .NET Framework to be able to add in the Libre Hardware Monitor Library to be able to read in CPU and GPU temperatures.
In the app, there are 2 main tabs: Maintenance and Diagnostics.
## MAINTENANCE
In the Maintenance tab, there are 2 buttons: Flush DNS and Delete Temporary Files, to improve PC performance. 
There is also a status label and a log of the actions completed
## DIAGNOSTICS
Currently, the Diagnostics tab contains CPU and GPU temperatures, updated every second.
I plan to add more function to this, but want to make sure anything I add is useful and isn't just something that could be found in a more efficient way, i.e MS Task Manager
I may end up adding some of the same readings just for continuity and to avoid having to switch windows constantly but for now I want to focus on providing benefits that TM cannot

## CHANGELOG
As stated prior, this was deleted upon creating my new cs file to update the .NET version, but I will try to accurately represent my changes and progress. 
>> 27/07/26: Created Repository and Initialised Visual Studios WinForms project, using C# and .NET 4.7.2
   27/07/26: Added Flush DNS button placeholder, and status label
   27/07/26: Wrote the script for the Flush DNS button, and made it update the status label
   27/07/26: Added "Delete Temporary Files" button placeholder and wrote the code for it
   27/07/26: Added an Event Log shared between both buttons, and made the status label communal
   27/07/26: Added basic output messages for the event log and statuses for the label
>> 30/07/26: Added a Tab Control and created tab "Diagnostics", while moving all my previous work onto the "Maintenance" tab
   30/07/26: Fixed minor bug in the status label when no temporary files existed to be deleted
   30/07/26: Installed Libre Hardware Monitor Library to my project
   30/07/26: Quickly realised this didn't work with .NET 4.7.2 and installed .NET 8.0
   30/07/26: Quickly realised I had to create an entire new project because I had instinctively done mine as using .NET Framework, which doesn't work with .NET 8.0
   30/07/26: Got annoyed that I had to start again
   30/07/26: Made new project file using correct settings and using .NET 8.0
   30/07/26: Rewrote all my previous work, and fixed another small logic error with the "Delete Temporary Files" button displaying the incorrect event log
   30/07/26: Reinstalled Libre Hardware Monitor Library and it worked this time!
   30/07/26: Added CPU and GPU Temperature Monitors using LHML
   30/07/26: Added a Timer so these values would update, and (incorrectly) coded the tick function (My loops within the function only read in the values without displaying them properly, so the temps never updated)
   30/07/26: Fixed the Timer tick function
   30/07/26: Did some general code optimisation on the buttons and timer
   30/07/26: Spent 40 minutes trying to push the changes to GitHub before realising I was using Powershell from an empty folder
   30/07/26: Attempted to rewrite README after realising everything got deleted
