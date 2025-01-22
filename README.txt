SYSTEM MINIMUM REQUIREMENT

OS Windows 1011
APPLICATION Visual Studio 2022.
RAM 4GB.
PROCESSOR ARM64 or x64; Quad-core.
DISPLAY A card that supports WXGA.
DISK SPACE 850MB of space.

If you can access this README, it is assumed you've already extracted the folder.

In order to be able to use the code you will need to:

1) Open File Explorer.
2) Select This PC.
3) Select the hard disk that contains your Visual studio (This is usually your C drive).
4) Choose the folder named Users.
5) Choose the folder that has a unique name (the name you chose when you received your laptop/computer).
6) Choose the folder called source.
7) Choose the folder called repos.
8) Drop the extracted PROG7312POEPART3 folder (that contains the .sln file) into your repos folder.
9) Open your Visual Studio 2022 application.
10) Select the project Solution called PROG712POEPART1.
11) Below the Tools combo box, there is a green arrow with the text Start next to it. Click it to run.

ALTERNATIVELY, you can run the executable that is located within the PROG7312POEPART1 folder that is within the PROG7312POEPART3 folder.

FEATURES:

The application is allows the user to be able to report issues, which allows users to send issues concerning their municipal area, send feedback to developers over concerns about the application and can now allow users to see and select and array of local events and announcements and be able to search those events/announcements to find out more about them. Users can also track service requests and review their respective status. A status for a requested service can be either in progress, completed or pending.

IMPLEMENTED FEEDBACK:

Users can now select a media file and view it, even if the place where they found the original file was tampered with.
There are more colours with the application and a logo.
There is a red exit button on each window of the application.
Users can now use a date range when searching for a local event and/or announcement.

******************************
IMPLEMENTATION REPORT

DATA STRUCTURES IMPLEMENTED:

The data structures that were used complete the Services Request Status were both a Binary Search Tree and a heap.

BINARY SEARCH TREE:
The main purpose of the Binary Search Tree is to effectively organise and retrieve service request information. The reason why this data was selected to complete this purpose was because it fit the use case effectively. A binary search tree is one of the best structures to use in terms of iterating through for deletion, insertion or finding a value, in comparison to the other trees because it does not shift values in memory. With its very efficient, linear way to search for a value, it is also not as hard as the other trees to implement in the Windows Form application. (W3schools.com n.d)


HEAP:
The main purpose of the heap data structure, in the implementation of the Windows Form application, is to manage complex relationships and optimise the display of service request status. The heap is used to display the details of each service request with their name, status and description. It is also used for the tracking those service requests as well. The reason why I thought the heap would be better suited for the use case is because there can be associated priorities in terms of status. In the web application, there are three statuses for each service request and they are "Completed", "In Progress" and "Pending" and the tree can prioritise based of the most desired being "In Progress" tasks and the least priority being "Completed" which would make searching more efficient. Heaps are dynamic which would be convenient for when users track different service requests. Each user can track a different amount of service requests each so it can handle that. (Advantages and disadvantages of Heap 2024)


BIBLIOGRAPHY:

Anon. (2024) Advantages and disadvantages of Heap, GeeksforGeeks. Available at: https://www.geeksforgeeks.org/applications-advantages-and-disadvantages-of-heap/ (Accessed: 12 November 2024). 
Anon. (no date) W3schools.com, W3Schools Online Web Tutorials. Available at: https://www.w3schools.com/dsa/dsa_data_binarysearchtrees.php#:~:text=A%20Binary%20Search%20Tree%20is,to%20shift%20values%20in%20memory. (Accessed: 12 November 2024). 

******************************