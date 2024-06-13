LINK TO GITHUB REPOSITORY: https://github.com/VCSTDN/prog7311-part-2-submission-ImJustLes.git

SYSTEM MINIMUM REQUIREMENT:

OS: Windows 10/11
APPLICATION: Visual Studio 2022.
RAM: 4GB.
PROCESSOR: ARM64 or x64; Quad-core.
DISPLAY: A card that supports WXGA.
DISK SPACE: 850MB of space.

INSTALL THESE NUGET PACKAGES: System.Data.SqlClient; 
			      Microsoft.VisualStudio.web.CodeGeneration.Design;

If you can access this README, it is assumed you've already extracted the folder.

In order to be able to use the code you will need to:

1) Open File Explorer.
2) Select This PC.
3) Select the hard disk that contains your Visual studio (This is usually your "C:" drive).
4) Choose the folder named "Users".
5) Choose the folder that has a unique name (the name you chose when you received your laptop/computer).
6) Choose the folder called "source".
7) Choose the folder called "repos".
8) Drop the extracted "PROG6212POEPART2" folder (that contains the .sln file) into your "repos" folder.
9) Install SQL Express (separate instructions on how to install beyond this set of instructions)
10) Open your Visual Studio 2022 application.
11) Select the project/Solution called "PROG6212POEPART2".
12) Hover over the combo box called "View" on the top of the application.
13) Select "SQL Server Object Explorer."
14) Select "PART 2 SQL QUERIES" in the solution explorer.
15) Use the script to create the database and tables necessary.
16) Right click on the server you created and saved your tables into and click on properties.
17) Copy the connection string.
18) Replace the already existing connection string in the " SingletonConnectionString" class
19) Remove the text beyond "Encrypt=true/false;" from your connection string.
19) Below the Tools combo box, there is a green arrow with the text "Start" next to it. Click it to run in your desired browser.

SYSTEM MINIMUM REQUIREMENTS:

OS: Windows 10, 11, and Windows Server 2016, 2019, 2022 or later
PROCESSOR: Speed of 1.4 GHz or more
RAM: 1 GB
SPACE: 6 GB of Disk Space, plus space for your databases and checkpoints.
LIMITATION: Microsoft SQL Server Express supports 1 physical processor, 1 GB RAM, and databases less than 10 GB each.

1) Click on the following link: https://www.microsoft.com/en-za/sql-server/sql-server-downloads
2) Download the Express free specialised edition.
3) Run the installer.
4) Select the "Basic" installation type.
5) Accept the Microsoft SQL Server Licence Terms.
6) Click on install. Specifying your install location is optional.
7) After the package is done installing, click on connect now. Installing SSMS is optional.
8) Continue to number 9 of the instructions before.

